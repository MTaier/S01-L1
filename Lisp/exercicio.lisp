(defun process-list (lst)
  "Aplica a função condicional sobre a lista."
  (mapcar (lambda (x)
            (if (>= x 4)
                (* x 2)
                (/ x 2.0)))
          lst))

(defun merge-processed-lists ()
  "Processa duas listas e as junta."
  (let ((list1 '(1 2 3))
        (list2 '(4 5 6)))
    (append (process-list list1) (process-list list2))))

(format t "Resultado: ~a~%" (merge-processed-lists))