export class TimeZone {

    private _utcOffset: string;

    constructor(utcOffset: string) {
        this._utcOffset = utcOffset;
    }

    localDate(input: Date | string | number): Date {
        return this._buildDateWithUtcOffset(new Date(input));
    }

    asUtc() {

    }

    private _buildDateWithUtcOffset(date: Date): Date {
        return new Date(`${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()} ${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}${this._utcOffset}`);
    }
}