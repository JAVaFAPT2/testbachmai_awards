import { Routes } from '@angular/router';
import {EmployeevotesComponent} from './employeevotes.component';
import {InspirationalpersonyearComponent} from './inspirationalpersonyear/inspirationalpersonyear.component'
import { InspirationalpersonyearlistComponent } from './inspirationalpersonyear/inspirationalpersonyearlist/inspirationalpersonyearlist.component';
import {DepartmentleaderyearComponent} from './departmentleaderyear/departmentleaderyear.component';
import {DepartmentyearComponent} from './departmentyear/departmentyear.component'
import {ProgramactivityyearComponent} from './programactivityyear/programactivityyear.component'
import {QualityimprovementyearComponent} from './qualityimprovementyear/qualityimprovementyear.component'
import { ItapplicationyearComponent } from './itapplicationyear/itapplicationyear.component';
import { ScientificresearchyearComponent } from './scientificresearchyear/scientificresearchyear.component';
import { ContributionyearComponent } from './contributionyear/contributionyear.component';
import { ImpressiveclinicalcasesComponent } from './impressiveclinicalcases/impressiveclinicalcases.component';
import {ItapplicationyearlistComponent} from "./itapplicationyear/itapplicationyearlist/itapplicationyearlist.component";
import {DepartmentyearlistComponent} from "./departmentyear/departmentyearlist/departmentyearlist.component";
import {
    DepartmentleaderyearlistComponent
} from "./departmentleaderyear/departmentleaderyearlist/departmentleaderyearlist.component";
import {
    ProgramactivityyearlistComponent
} from "./programactivityyear/programactivityyearlist/programactivityyearlist.component";
import {
    QualityimprovementyearlistComponent
} from "./qualityimprovementyear/qualityimprovementyearlist/qualityimprovementyearlist.component";
import {
    ScientificresearchyearlistComponent
} from "./scientificresearchyear/scientificresearchyearlist/scientificresearchyearlist.component";
import {ContributionyearlistComponent} from "./contributionyear/contributionyearlist/contributionyearlist.component";
import {
    ImpressiveclinicalcaseslistComponent
} from "./impressiveclinicalcases/impressiveclinicalcaseslist/impressiveclinicalcaseslist.component";
export default [
    {
        path     : '',
        pathMatch : 'full',
        component: EmployeevotesComponent,
    },
    {
        path     : 'programactivityyear',
        component: ProgramactivityyearComponent,
        children: [
            {
                path: '',
                component: ProgramactivityyearlistComponent,
            },
        ]
    },
    {
        path     : 'departmentyear',
        component: DepartmentyearComponent,
        children: [
            {
                path: '',
                component: DepartmentyearlistComponent,
            },
        ]
    },
    {
        path     : 'departmentleaderyear',
        component: DepartmentleaderyearComponent,
        children: [
            {
                path: '',
                component: DepartmentleaderyearlistComponent,
            },
        ]
    },
    {
        path     : 'inspirationalpersonyear',
        component: InspirationalpersonyearComponent,
        children: [
            {
                path: '',
                component: InspirationalpersonyearlistComponent,
            },
        ],
    },
    {
        path: 'qualityimprovementyear',
        component: QualityimprovementyearComponent,
        children: [
            {
                path: '',
                component: QualityimprovementyearlistComponent,
            },
        ]
    },
    {
        path: 'itapplicationyear',
        component: ItapplicationyearComponent,
        children: [
            {
                path: '',
                component: ItapplicationyearlistComponent,
            },
        ]
    },
    {
        path: 'scientificresearchyear',
        component: ScientificresearchyearComponent,
        children: [
            {
                path: '',
                component: ScientificresearchyearlistComponent,
            },
        ]
    },
    {
        path: 'contributionyear',
        component: ContributionyearComponent,
        children: [
            {
                path: '',
                component: ContributionyearlistComponent,
            },
        ]

    },
    {
        path: 'impressiveclinicalcases',
        component: ImpressiveclinicalcasesComponent,
        children: [
            {
                path: '',
                component: ImpressiveclinicalcaseslistComponent,
            },
        ]

    }
] as Routes;
