import { Component,EventEmitter } from '@angular/core';
import {CheckService} from './check.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private checkService: CheckService) {}
  title = 'A-form';
  dis = 'true';
  notifications= [
    {id:1,title : 'first title'},
    {id:2,title : 'second title'},
    {id:3,title : 'third title'}
  ]

}
