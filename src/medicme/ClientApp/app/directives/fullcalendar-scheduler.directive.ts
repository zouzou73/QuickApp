// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

import { Directive, Attribute, ElementRef, Input, OnInit } from '@angular/core';
import * as $ from 'jquery';
import 'fullcalendar/dist/fullcalendar.js' ;



@Directive({
    selector: '[fullcalendarScheduler]'
})
export class FullcalendarSchedulerDirective implements OnInit {
    constructor(private el: ElementRef) {

    }

    ngOnInit() {
        (<any>$(this.el.nativeElement)).fullCalendar({
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,week,basicDay,listDay'
            },
            resources: [
                { id: 'a', title: 'Room A' },
                { id: 'b', title: 'Room B' },
                { id: 'c', title: 'Room C' },
                { id: 'd', title: 'Room D' }
            ],
            events: [
                {
                    title: 'event1',
                    start: '2017-01-01'
                },
                {
                    title: 'event2',
                    start: '2017-01-05',
                    end: '2017-01-07'
                },
                {
                    title: 'event3',
                    start: '2017-01-09T12:30:00',
                    allDay: false // will make the time show
                }
               
            ],

        });
    }
}