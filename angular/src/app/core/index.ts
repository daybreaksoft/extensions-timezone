import { TimeZone } from './timezone';

export * from './timezone';

export const timeZone = function () {
    return new TimeZone();
}