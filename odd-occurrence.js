function solution(A) {
    // write your code in JavaScript (Node.js 8.9.4)
    const l = A.length;
    const temp = {};
    for (var n = 0; n < l; n++) {
        const e = A[n];
        const count = temp[e];
        temp[e] = count ? count + 1 : 1;
    }
    for (e in temp) {
        const count = parseInt(temp[e]);
        if (count % 2 === 1) {
            return parseInt(e);
        }
    }
    return 0;
}