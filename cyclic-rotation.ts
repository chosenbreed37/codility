// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A, K) {
    // write your code in JavaScript (Node.js 8.9.4)
    const r = [];
    const l = A.length;
    
    for (var n = 0; n < l; n++) {
        const e = A[n];
        const m = (n + K) % l;
        r[m] = e;
    }
    return r;
}