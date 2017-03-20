import { Component } from '@angular/core';
import { fadeInOut } from '../../services/animations';

@Component({
    selector: 'labs',
    templateUrl: './labs.component.html',
    styleUrls: ['./labs.component.css'],
    animations: [fadeInOut]
})
export class labsComponent {
}