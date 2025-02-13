import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-qualityimprovementyear',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
  templateUrl: './qualityimprovementyear.component.html',
  styleUrl: './qualityimprovementyear.component.scss'
})
export class QualityimprovementyearComponent {

}
