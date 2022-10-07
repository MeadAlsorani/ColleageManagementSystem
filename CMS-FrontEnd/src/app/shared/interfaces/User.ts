export interface User {
  id: string;
  userName: string;
  email: string;
  token: string;
  role: string;
  fullName: string;
  refreshToken?: string;
}
