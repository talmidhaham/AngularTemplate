import { InjectionToken } from '@angular/core';

export interface AppSettings {
  apiBaseUrl: string;
  enableLogging: boolean;
  appName: string;
}

export const APP_SETTINGS = new InjectionToken<AppSettings>('APP_SETTINGS');

export const AppSettingsValues: AppSettings = {
  apiBaseUrl: 'http://localhost:5299/api/',
  enableLogging: true,
  appName: 'My Angular App'
};
