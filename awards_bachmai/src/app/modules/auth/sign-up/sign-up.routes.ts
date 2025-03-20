import { Route } from '@angular/router';
import { AuthSignUpComponent } from './sign-up.component';

export const signUpRoutes: Route[] = [
    {
        path: '',
        component: AuthSignUpComponent
    }
];

export default signUpRoutes;
