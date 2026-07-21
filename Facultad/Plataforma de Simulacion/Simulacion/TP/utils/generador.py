
import math
import random

def truncate(number, digits) -> float:
    stepper = 10.0 ** digits
    return math.trunc(stepper * number) / stepper

def lineal(seed, size, m, a, c):
    numbers = []
    actual = seed
    for i in range(size):
        next = (actual * a + c) % m
        rnd = (next / m)
        trunc = truncate(rnd, 4)
        numbers.append(trunc)
        actual = next
    return numbers

def multiplicativo(seed, size, m, a):
    numbers = []
    actual = seed
    for i in range(size):
        next = (actual * a) % m
        rnd = (next / m)
        trunc = truncate(rnd, 4)
        numbers.append(trunc)
        actual = next
    return numbers

def lenguaje(seed, size):
    random.seed(seed)
    numbers = []
    for i in range(size):
        rnd = random.random()
        trunc = truncate(rnd, 4)
        numbers.append(trunc)
    return numbers

def generate(seed, g, k, c, size, method):
    seed = int(seed)
    if g == None:
        g = 25
    else:
         g = int(g)
    m = 2**g
    if k == None:
        k = 30
    else:
        k = int(k)
    a = 1 + 4*k
    if c == None:
        c = 6949
    else:
        c = int(c)
    
    if method == 'lineal':
        numbers = lineal(seed, size, m, a, c)
    elif method == 'multiplicativo':
        numbers = multiplicativo(seed, size, m, a)
    elif method == 'lenguaje':
        numbers = lenguaje(seed, size)
    return numbers