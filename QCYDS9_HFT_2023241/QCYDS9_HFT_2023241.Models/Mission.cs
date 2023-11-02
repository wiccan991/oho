﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QCYDS9_HFT_2023241.Models
{
    [Table("missions")]
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MissionId { get; set; }
        [ForeignKey(nameof(Spaceship))]
        public int SpaceshipId { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public int BudgetMDollar { get; set; }
        public string Objective { get; set; }
        public int LaunchYear { get; set; }

        [NotMapped]
        public virtual IEnumerable<Astronaut> Astronauts { get; set; }
        public virtual Spaceship Spaceship { get; set; }

        public Mission()
        {

        }

        public Mission(int missionId, int spaceshipId, string name, int budget, string objective, int launcyear)
        {
            MissionId = missionId;
            SpaceshipId = spaceshipId;
            Name = name;
            BudgetMDollar = budget;
            Objective = objective;
            LaunchYear = launcyear;

        }
        public Mission(int missionId, Spaceship spaceship, string name, int budget, string objective, int launcyear)
        {
            MissionId = missionId;
            SpaceshipId = spaceship.Id;
            Name = name;
            BudgetMDollar = budget;
            Objective = objective;
            LaunchYear = launcyear;

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
    }