// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

import { NgModule, ErrorHandler } from "@angular/core";
import { RouterModule } from "@angular/router";
import { FormsModule } from "@angular/forms"
import { UniversalModule } from "angular2-universal";

import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ToastyModule } from 'ng2-toasty';
//Bug in ng2-bootstrap packaging prevents loading individual modules. Check back in future updates
//import { TooltipModule } from "ng2-bootstrap/tooltip";
//import { PopoverModule } from "ng2-bootstrap/popover";
//import { ModalModule } from 'ng2-bootstrap/modal';
//Temp: load all from main package for now
import { ModalModule, TooltipModule, PopoverModule, DropdownModule, CarouselModule } from "ng2-bootstrap"
import { ChartsModule } from 'ng2-charts';

import { AppRoutingModule } from './app-routing.module';
import { AppErrorHandler } from './app-error.handler';
import { AlertService } from './services/alert.service';
import { ConfigurationService } from './services/configuration.service';
import { AccountService } from './services/account.service';
import { LocalStoreManager } from './services/local-store-manager.service';
import { EndpointFactory } from './services/endpoint-factory.service';
import { AppTitleService } from './services/app-title.service';

import { EqualValidator } from './directives/equal-validator.directive';
import { LastElementDirective } from './directives/last-element.directive';
import { AutofocusDirective } from './directives/autofocus.directive';
import { BootstrapTabDirective } from './directives/bootstrap-tab.directive';
import { BootstrapToggleDirective } from './directives/bootstrap-toggle.directive';
import { BootstrapSelectDirective } from './directives/bootstrap-select.directive';
import { FullcalendarSchedulerDirective } from './directives/fullcalendar-scheduler.directive';

import { GroupByPipe } from './pipes/group-by.pipe';

import { AppComponent } from "./components/app.component";
import { LoginComponent } from "./components/login/login.component";
import { HomeComponent } from "./components/home/home.component";
import { AppointmentsComponent } from "./components/appointments/appointments.component";
import { labsComponent } from "./components/lab/labs.component";
import { ProductsComponent } from "./components/products/product-list.component";
import { ProductFilterPipe } from "./components/products/product-filter.pipe";

import { ConsultationsComponent } from "./components/consultations/consultations.component";
import { PatientsComponent } from "./components/patients/patients.component";
import { ProvidersComponent } from "./components/providers/providers.component";
import { SettingsComponent } from "./components/settings/settings.component";
import { UserInfoComponent } from "./components/settings/controls/user-info.component";
import { UserPreferencesComponent } from "./components/settings/controls/user-preferences.component";
import { UsersManagementComponent } from "./components/settings/controls/users-management.component";
import { RolesManagementComponent } from "./components/settings/controls/roles-management.component";
import { RoleEditorComponent } from "./components/settings/controls/role-editor.component";
import { AboutComponent } from "./components/about/about.component";
import { NotFoundComponent } from "./components/not-found/not-found.component";
import { SearchBoxComponent } from "./components/controls/search-box.component";
import { StatisticsDemoComponent } from "./components/controls/statistics-demo.component";
import { TodoDemoComponent } from "./components/controls/todo-demo.component";
import { BannerDemoComponent } from "./components/controls/banner-demo.component";
import { AccordionModule } from 'primeng/components/accordion/accordion';
import { MenuItem } from 'primeng/components/common/api';

@NgModule({
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule,
        AccordionModule,
       
        AppRoutingModule,
        NgxDatatableModule,
        ToastyModule.forRoot(),
        TooltipModule.forRoot(),
        PopoverModule.forRoot(),
        DropdownModule.forRoot(),
        CarouselModule.forRoot(),
        ModalModule.forRoot(),
        ChartsModule
    ],
    declarations: [
        AppComponent,
        LoginComponent,
        HomeComponent,
        AppointmentsComponent,
        labsComponent,
        ConsultationsComponent,
        PatientsComponent,ProductFilterPipe,
        ProvidersComponent, ProductsComponent,
        SettingsComponent, UserInfoComponent, UserPreferencesComponent, UsersManagementComponent, RolesManagementComponent, RoleEditorComponent,
        AboutComponent,
        NotFoundComponent,
        SearchBoxComponent,
        StatisticsDemoComponent, TodoDemoComponent, BannerDemoComponent,
        EqualValidator,
        FullcalendarSchedulerDirective,
        LastElementDirective,
        AutofocusDirective,
        BootstrapTabDirective,
        BootstrapToggleDirective,
        BootstrapSelectDirective,
        GroupByPipe
    ],
    providers: [
        { provide: ErrorHandler, useClass: AppErrorHandler },
        AlertService,
        ConfigurationService,
        AppTitleService,
        AccountService,
        LocalStoreManager,
        EndpointFactory,
        
    ],
    bootstrap: [AppComponent]
})

export class AppModule { }
