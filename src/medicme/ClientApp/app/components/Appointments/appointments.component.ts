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

import { IDoctor } from './doctor';

@Component({
    selector: 'appointments',
    templateUrl: './appointments.component.html',
    styleUrls: ['./appointments.component.css'],
    animations: [fadeInOut]
   
})

export class AppointmentsComponent implements OnInit { 
    pageTitle: string = 'Doctor List!';
    imageWidth: number = 50;
    imageMargin: number = 2;
    showImage: boolean = false;
    listFilter: string = 'dentist';
   doctors: IDoctor[] = [
       {
           "doctortId": 1,
           "doctorName": "lll",
           "doctorSpeciality": "dentist",
           "address": "fvnbvnvn v", 
           "phoneNumber": 3,
           "starRating": 1.6,
           "imageUrl": "http://www.rheumcare.ro/wp-content/uploads/bfi_thumb/doc4-2zth05lwgqbf5ie4wgds74.png"

           
           
        }
        
    ];
    toggleImage(): void {
        this.showImage = !this.showImage;
    }
    ngOnInit(): void {
        console.log('In OnInit');
    }
}


