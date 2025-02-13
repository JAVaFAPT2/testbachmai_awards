import {ChangeDetectorRef, Component} from '@angular/core';
import {Observable} from "rxjs";
import {Contact} from "../contacts.types";
import {ContactsService} from "../contacts.service";

@Component({
  selector: 'app-contributionyear',
  imports: [],
  templateUrl: './itapplicationyeardetail.component.html',
  styleUrl: './itapplicationyeardetail.component.scss'
})
export class ItapplicationyeardetailComponent {
    userVoteCount$: Observable<number>;
    contact: Contact;

    constructor(
        private _contactsService: ContactsService,
        private _changeDetectorRef: ChangeDetectorRef
    ) {
        this.userVoteCount$ = this._contactsService.userVoteCount$;
    }

    toggleVote(): void {
        if (this.contact) {
            this._contactsService.toggleVote(this.contact).subscribe(() => {
                this._changeDetectorRef.markForCheck();
            });
        }
    }

}
