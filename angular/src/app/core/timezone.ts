export class TimeZone {
    constructor() { }

    asLocalDateTime(input: Date | string | number, utcOffset: string): Date {
        const date = new Date(input);
        return new Date(`${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()} ${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}${utcOffset}`);
    }

    asUtcDateTime(input: Date | string | number): Date {
        const date = new Date(input);
        return new Date(`${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()} ${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}.000Z`);
    }

    asUtcDate(input: Date | string | number): Date {
        const date = new Date(input);
        return new Date(`${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()} 00:00:00.000Z`);
    }
}