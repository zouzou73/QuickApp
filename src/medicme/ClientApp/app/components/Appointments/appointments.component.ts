// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================


import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { fadeInOut } from '../../services/animations';
import { ActivatedRoute } from '@angular/router';
import { BootstrapTabDirective } from "../../directives/bootstrap-tab.directive";
import 'rxjs/add/operator/switchMap';

import { AccountService, RolesChangedEventArg } from "../../services/account.service";
import { Permission } from '../../models/permission.model';



@Component({
    selector: 'appointments',
    templateUrl: './appointments.component.html',
    styleUrls: ['./appointments.component.css'],
    animations: [fadeInOut]
   
})

export class AppointmentsComponent {
    
}
