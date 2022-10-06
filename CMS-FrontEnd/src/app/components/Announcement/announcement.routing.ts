import { EditAnnouncementComponent } from './edit-announcement/edit-announcement.component';
import { AddAnnouncementComponent } from './add-announcement/add-announcement.component';
import { Routes, RouterModule } from '@angular/router';
import { AnnouncementsListComponent } from './announcements-list/announcements-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'list' },
  { path: 'list', component: AnnouncementsListComponent },
  { path: 'add', component: AddAnnouncementComponent },
  { path: 'edit/:id', component: EditAnnouncementComponent },
];

export const AnnouncementRoutes = RouterModule.forChild(routes);
