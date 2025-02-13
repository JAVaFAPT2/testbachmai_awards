import { Component, HostListener } from '@angular/core';
import { AuthService } from './core/auth/auth.service';
import {TabStackService} from "./core/auth/guards/TabStackService";
import {RouterOutlet} from "@angular/router";


@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss'],
    standalone: true,
    imports: [RouterOutlet]
})
export class AppComponent {
    constructor(private authService: AuthService, private tabStackService: TabStackService) {
        this.tabStackService.add();
    }

    @HostListener('window:beforeunload', ['$event'])
    beforeCloseTabOrBrowserAndRefresh(event: Event): void {
        this.tabStackService.remove();
        if (this.tabStackService.isEmpty()) {
            this.authService.clearAccessToken();
        }
    }
}
