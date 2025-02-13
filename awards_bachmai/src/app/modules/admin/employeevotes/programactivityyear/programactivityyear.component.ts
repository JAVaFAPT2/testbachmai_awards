import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-programactivityyear',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
  templateUrl: './programactivityyear.component.html',
  styleUrl: './programactivityyear.component.scss'
})
export class ProgramactivityyearComponent {

}
