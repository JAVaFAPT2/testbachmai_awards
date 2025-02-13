import {
  ChangeDetectionStrategy,
  Component,
  ViewEncapsulation,
} from '@angular/core';
import { RouterOutlet } from '@angular/router';


@Component({
  selector: 'app-inspirationalpersonyear',  
  templateUrl: './inspirationalpersonyear.component.html',
  styleUrl: './inspirationalpersonyear.component.scss',
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterOutlet],
})
export class InspirationalpersonyearComponent {

}
