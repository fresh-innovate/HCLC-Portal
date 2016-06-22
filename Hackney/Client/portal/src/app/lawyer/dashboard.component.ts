import { Component, OnInit} from "@angular/core";
import { ROUTER_DIRECTIVES } from '@angular/router';

@Component({
    templateUrl: '/portal/app/lawyer/dashboard.component.html',
    directives: [ ROUTER_DIRECTIVES ]
})
export class LawyerDashboardComponent implements OnInit {
    constructor() { }
    ngOnInit() {
    }
}