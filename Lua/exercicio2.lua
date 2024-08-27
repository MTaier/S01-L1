local x = {}
count = 0


for i = 0, 100 do
    x[i] = math.random(0, 50)
    print(x[i])
end

for i = 0, 100 do
    resto = x[i] % 2

    if resto == 0 then 
        count = count + 1
    end
end

print(count .. " numeros pares")