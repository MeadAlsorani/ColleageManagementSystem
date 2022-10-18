import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class DashboardService {
  constructor(private http: HttpClient) {}

  getAnnouncements(month: number) {
    return this.http.get(
      `${environment.apiUrl}Dashboard/Announcements?month=${month}`
    );
  }

  getIncomes(month: number = -1) {
    return this.http.get(
      `${environment.apiUrl}Dashboard/Incomes?month=${month}`
    );
  }
  getOutcomes(month: number = -1) {
    return this.http.get(
      `${environment.apiUrl}Dashboard/Outcome?month=${month}`
    );
  }

  getCounts() {
    return this.http.get(`${environment.apiUrl}Dashboard/Counts`);
  }
  getAttendanceCounts() {
    return this.http.get(`${environment.apiUrl}Dashboard/AttendanceToday`);
  }
}
