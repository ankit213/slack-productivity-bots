﻿declare var describe, it, beforeEach, expect;
import { async, inject, TestBed, ComponentFixture } from '@angular/core/testing';
import { Provider } from "@angular/core";
import { Router, ActivatedRoute, RouterModule, Routes } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { RouterLinkStubDirective } from '../../shared/mock/mock.routerLink';
import { TaskMailModule } from '../../taskmail/taskMail.module';
import { MockTaskMailService } from '../../shared/mock/mock.taskmailReport.service';
import { TaskService } from '../taskmail.service';
import { DatePipe } from '@angular/common';
import { LoaderService } from '../../shared/loader.service';
import { StringConstant } from '../../shared/stringConstant';
import { TaskMailDetailsComponent } from './taskmail-details.component';
import { MockRouter } from '../../shared/mock/mock.router';
import { ActivatedRouteStub } from '../../shared/mock/mock.activatedroute';

let promise: TestBed;

describe('TaskMail Detials Tests', () => {
    const routes: Routes = [];

    beforeEach(async(() => {
        this.promise = TestBed.configureTestingModule({
            declarations: [RouterLinkStubDirective], 
            imports: [TaskMailModule, RouterModule.forRoot(routes, { useHash: true }) 
            ],
            providers: [
                { provide: ActivatedRoute, useClass: ActivatedRouteStub },
                { provide: TaskService, useClass: MockTaskMailService },
                { provide: StringConstant, useClass: StringConstant },
                { provide: Router, useClass: MockRouter },
                { provide: DatePipe, useClass: DatePipe },
                { provide: LoaderService, useClass: LoaderService }
            ]
        }).compileComponents();
    }));

    it("should be defined", () => {
        let fixture = TestBed.createComponent(TaskMailDetailsComponent);             
        let taskMailDetailsComponent = fixture.componentInstance;
        expect(taskMailDetailsComponent).toBeDefined();
    });

    it('Shows details of task mail report for an employee on initialization', () => {
        let fixture = TestBed.createComponent(TaskMailDetailsComponent); 
        let activatedRoute = fixture.debugElement.injector.get(ActivatedRoute);
        activatedRoute.testParams = { UserId: "1", UserRole: "Admin", UserName: "test" };
        let taskMailDetailsComponent = fixture.componentInstance;
        taskMailDetailsComponent.getTaskMailDetails();
        expect(taskMailDetailsComponent.taskMail.length).toBe(1);
    });

    it('Shows details of task mail report for an employee on Privious Date', () => {
        let fixture = TestBed.createComponent(TaskMailDetailsComponent);       
        let taskMailDetailsComponent = fixture.componentInstance;
        taskMailDetailsComponent.getTaskMailPrevious("test", "1", "Admin", "10-09-2016");
        expect(taskMailDetailsComponent.taskMail.length).toBe(1);
    });

    it('Shows details of task mail report for an employee on Next Date', () => {
        let fixture = TestBed.createComponent(TaskMailDetailsComponent);          
        let taskMailDetailsComponent = fixture.componentInstance;
        taskMailDetailsComponent.getTaskMailNext("test", "1", "Admin", "10-09-2016");
        expect(taskMailDetailsComponent.taskMail.length).toBe(1);
    });

    it('Shows details of task mail report for an employee on Selected Date', () => {
        let fixture = TestBed.createComponent(TaskMailDetailsComponent);            
        let taskMailDetailsComponent = fixture.componentInstance;
        taskMailDetailsComponent.getTaskMailForSelectedDate("test", "1", "Admin", "10-09-2016", "10-09-2016");
        expect(taskMailDetailsComponent.taskMail.length).toBe(1);
    });
});
