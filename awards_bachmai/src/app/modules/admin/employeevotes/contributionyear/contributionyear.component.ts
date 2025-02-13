import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-contributionyear',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
  templateUrl: './contributionyear.component.html',
  styleUrl: './contributionyear.component.scss'
})
export class ContributionyearComponent {

}
