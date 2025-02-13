import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-impressiveclinicalcases',
  templateUrl: './impressiveclinicalcases.component.html',
  styleUrl: './impressiveclinicalcases.component.scss',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],

})
export class ImpressiveclinicalcasesComponent {

}
