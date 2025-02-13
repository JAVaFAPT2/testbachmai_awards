import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-scientificresearchyear',
  templateUrl: './scientificresearchyear.component.html',
  styleUrl: './scientificresearchyear.component.scss',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
})
export class ScientificresearchyearComponent {

}
