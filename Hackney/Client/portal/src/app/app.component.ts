import {Component, OnInit} from "@angular/core";
import { ROUTER_DIRECTIVES, Routes, Router } from '@angular/router';

import {PortalComponent} from "./portal/portal.component";
import {ClientDashboardComponent} from "./client/dashboard.component";
import {LawyerDashboardComponent} from "./lawyer/dashboard.component";
import {DashboardComponent} from "./dashboard/dashboard.component";

import { APP_PROVIDERS } from './app.providers';

@Component({
    selector: "app",
    templateUrl: "/portal/app/app.component.html",
    directives: [ ROUTER_DIRECTIVES ],
    providers: [ APP_PROVIDERS ]
})
@Routes([
   {path: '/portal', component: PortalComponent},
   {path: '/client-portal', component: ClientDashboardComponent},
   {path: '/lawyer-portal', component: LawyerDashboardComponent}
])
export class AppComponent implements OnInit {
    constructor(private router: Router) {
    }
    ngOnInit() {
        console.log("Application component initialized ...");
    }
}