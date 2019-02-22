import { TimeZone } from './timezone';

export * from './timezone';

export const timeZone = function (utcOffset: string) {
    return new TimeZone(utcOffset);
}