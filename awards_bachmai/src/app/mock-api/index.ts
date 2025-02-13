import { inject, Injectable } from '@angular/core';
import { AcademyMockApi } from './apps/academy/api';
import { ContactsMockApi } from './apps/contacts/api';
import { ECommerceInventoryMockApi } from './apps/ecommerce/inventory/api';
import { FileManagerMockApi } from './apps/file-manager/api';
import { HelpCenterMockApi } from './apps/help-center/api';
import { MailboxMockApi } from './apps/mailbox/api';
import { NotesMockApi } from './apps/notes/api';
import { ScrumboardMockApi } from './apps/scrumboard/api';
import { TasksMockApi } from './apps/tasks/api';
import { AuthMockApi } from './common/auth/api';
import { MessagesMockApi } from './common/messages/api';
import { NavigationMockApi } from './common/navigation/api';
import { NotificationsMockApi } from './common/notifications/api';
import { SearchMockApi } from './common/search/api';
import { ShortcutsMockApi } from './common/shortcuts/api';
import { UserMockApi } from './common/user/api';
import { AnalyticsMockApi } from './dashboards/analytics/api';
import { CryptoMockApi } from './dashboards/crypto/api';
import { FinanceMockApi } from './dashboards/finance/api';
import { ProjectMockApi } from './dashboards/project/api';
import { ActivitiesMockApi } from './pages/activities/api';
import { IconsMockApi } from './ui/icons/api';

@Injectable({ providedIn: 'root' })
export class MockApiService {
    academyMockApi = inject(AcademyMockApi);
    activitiesMockApi = inject(ActivitiesMockApi);
    analyticsMockApi = inject(AnalyticsMockApi);
    authMockApi = inject(AuthMockApi);    
    contactsMockApi = inject(ContactsMockApi);
    cryptoMockApi = inject(CryptoMockApi);
    eCommerceInventoryMockApi = inject(ECommerceInventoryMockApi);
    fileManagerMockApi = inject(FileManagerMockApi);
    financeMockApi = inject(FinanceMockApi);
    helpCenterMockApi = inject(HelpCenterMockApi);
    iconsMockApi = inject(IconsMockApi);
    mailboxMockApi = inject(MailboxMockApi);
    messagesMockApi = inject(MessagesMockApi);
    navigationMockApi = inject(NavigationMockApi);
    notesMockApi = inject(NotesMockApi);
    notificationsMockApi = inject(NotificationsMockApi);
    projectMockApi = inject(ProjectMockApi);
    searchMockApi = inject(SearchMockApi);
    scrumboardMockApi = inject(ScrumboardMockApi);
    shortcutsMockApi = inject(ShortcutsMockApi);
    tasksMockApi = inject(TasksMockApi);
    userMockApi = inject(UserMockApi);
}
