def solution(A):
    g = dict()
    n = len(A)
    for i in range(0, n):
        e = A[i]
        if e in g:
            t = g[e]
            g[e] = (t[0]+1, t[1])
        else:
            g[e] = (1, i)
    for k in g:
        v = g[k]
        if (v[0] > (n / 2)):
            return v[1]
    return -1    
    

def test(input, expected):
    actual = solution(input)
    print('Test: ', input)
    if expected == actual:
        print('Pass')
    else:
        print('Fail')
        print('Expected: ', expected)
        print('Actual: ', actual)

test([3, 4, 3, 2, 3, -1, 3, 3], 0)   