import {ChangeDetectionStrategy, Component, OnInit, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-departmentyear',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
  templateUrl: './departmentyear.component.html',
  styleUrl: './departmentyear.component.scss'
})
export class DepartmentyearComponent implements OnInit  {
  ngOnInit() {
    console.log('OnInit page 1');
  }
}
