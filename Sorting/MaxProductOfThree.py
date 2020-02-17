# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    # write your code in Python 3.6
    A.sort()
    trio = A[len(A) - 3:]
    product = 1
    for x in trio:
        product *= x
    return product    
