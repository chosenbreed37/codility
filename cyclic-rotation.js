// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');
function solution(A, K) {
    // write your code in JavaScript (Node.js 8.9.4)
    var r = [];
    var l = A.length;
    for (var n = 0; n < l; n++) {
        var e = A[n];
        var m = (n + K) % l;
        r[m] = e;
    }
    return r;
}
//# sourceMappingURL=cyclic-rotation.js.map