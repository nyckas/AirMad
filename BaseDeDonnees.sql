select r.id,r.passager,r.destination,r.nationalite,r.date,r.classe,r.vol,r.type,(v.prixBillet+c.tarif) as prix from destination d, reservation r, classe c, vol v where r.destination = d.nom and c.nom = r.classe and v.destination = r.destination