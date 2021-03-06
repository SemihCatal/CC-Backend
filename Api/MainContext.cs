﻿using CommunicaptionBackend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicaptionBackend.Api
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options)
            : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<MediaEntity> Medias { get; set; }
        public DbSet<SettingsEntity> Settings { get; set; }
        public DbSet<TextEntity> Texts { get; set; }
        public DbSet<ArtEntity> Arts { get; set; }
    }
}
