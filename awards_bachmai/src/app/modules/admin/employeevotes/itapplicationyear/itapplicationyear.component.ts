import {
  ChangeDetectionStrategy,
  Component,
  ViewEncapsulation,
} from '@angular/core';
import { RouterOutlet } from '@angular/router';


@Component({
    selector: 'app-inspirationalpersonyear',
    templateUrl: './itapplicationyear.component.html',
    styleUrl: './itapplicationyear.component.scss',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
    standalone: true
})
export class ItapplicationyearComponent {
    ngOnInit(): void {
        // The service will automatically load initial data when injected
        console.log('ItapplicationyearComponent initialized');
    }
}
