import {ChangeDetectionStrategy, Component, ViewEncapsulation} from '@angular/core';
import {RouterOutlet} from "@angular/router";

@Component({
  selector: 'app-departmentleaderyear',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    imports: [RouterOutlet],
  templateUrl: './departmentleaderyear.component.html',
  styleUrl: './departmentleaderyear.component.scss'
})
export class DepartmentleaderyearComponent {

}
