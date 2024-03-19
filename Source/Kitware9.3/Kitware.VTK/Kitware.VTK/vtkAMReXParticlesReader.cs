using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAMReXParticlesReader
	/// </summary>
	/// <remarks>
	///  reader for AMReX plotfiles particle data.
	///
	/// vtkAMReXParticlesReader readers particle data from AMReX plotfiles. The
	/// reader is based on the  `ParticleContainer::Restart` and
	/// `amrex_binary_particles_to_vtp` files in the
	/// [AMReX code](https://amrex-codes.github.io/).
	///
	/// The reader reads all levels in as blocks in output multiblock dataset
	/// distributed datasets at each level between ranks in a contiguous fashion.
	///
	/// To use the reader, one must set the `PlotFileName` and `ParticleType` which
	/// identifies the type particles from the PlotFileName to read.
	///
	/// The reader provides ability to select point data arrays to be made available
	/// in the output. Note that due to the nature of the file structure, all
	/// variables are still read in and hence deselecting arrays does not reduce I/O
	/// calls or initial memory requirements.
	/// </remarks>
	// Token: 0x02000229 RID: 553
	public class vtkAMReXParticlesReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060067D5 RID: 26581 RVA: 0x00095F47 File Offset: 0x00094147
		static vtkAMReXParticlesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMReXParticlesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMReXParticlesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060067D6 RID: 26582 RVA: 0x00095F6F File Offset: 0x0009416F
		public vtkAMReXParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060067D7 RID: 26583
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067D8 RID: 26584 RVA: 0x00095F80 File Offset: 0x00094180
		public new static vtkAMReXParticlesReader New()
		{
			vtkAMReXParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXParticlesReader.vtkAMReXParticlesReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067D9 RID: 26585 RVA: 0x00095FD4 File Offset: 0x000941D4
		public vtkAMReXParticlesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMReXParticlesReader.vtkAMReXParticlesReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060067DA RID: 26586 RVA: 0x00096018 File Offset: 0x00094218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060067DB RID: 26587
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXParticlesReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string fname, [MarshalAs(UnmanagedType.LPUTF8Str)] string particlesType);

		/// <summary>
		/// Returns 1 is fname refers to a plotfile that the reader can read.
		/// </summary>
		// Token: 0x060067DC RID: 26588 RVA: 0x00096024 File Offset: 0x00094224
		public static int CanReadFile(string fname, string particlesType)
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_CanReadFile_01(fname, particlesType);
		}

		// Token: 0x060067DD RID: 26589
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default, the global
		/// vtkMultiProcessController will be used.
		/// </summary>
		// Token: 0x060067DE RID: 26590 RVA: 0x00096040 File Offset: 0x00094240
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetController_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x060067DF RID: 26591
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMReXParticlesReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067E0 RID: 26592 RVA: 0x000960B0 File Offset: 0x000942B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060067E1 RID: 26593
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMReXParticlesReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067E2 RID: 26594 RVA: 0x000960D0 File Offset: 0x000942D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060067E3 RID: 26595
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkAMReXParticlesReader_GetParticleType_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the particle type to read. By default, this is set to 'particles'.
		/// </summary>
		// Token: 0x060067E4 RID: 26596 RVA: 0x000960EC File Offset: 0x000942EC
		public string GetParticleType()
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetParticleType_05(base.GetCppThis());
		}

		// Token: 0x060067E5 RID: 26597
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_GetPlotFileName_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the AMReX plotfile. Note this is a directory on the filesystem and
		/// not the file.
		/// </summary>
		// Token: 0x060067E6 RID: 26598 RVA: 0x0009610C File Offset: 0x0009430C
		public string GetPlotFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetPlotFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060067E7 RID: 26599
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_GetPointDataArraySelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get vtkDataArraySelection instance to select point arrays to read. Due to
		/// the nature of the AMReX particles files, all point data is read in from the
		/// disk, despite certain arrays unselected. The unselected arrays will be
		/// discarded from the generated output dataset.
		/// </summary>
		// Token: 0x060067E8 RID: 26600 RVA: 0x00096148 File Offset: 0x00094348
		public vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXParticlesReader.vtkAMReXParticlesReader_GetPointDataArraySelection_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060067E9 RID: 26601
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXParticlesReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067EA RID: 26602 RVA: 0x000961B8 File Offset: 0x000943B8
		public override int IsA(string type)
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060067EB RID: 26603
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXParticlesReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067EC RID: 26604 RVA: 0x000961D8 File Offset: 0x000943D8
		public new static int IsTypeOf(string type)
		{
			return vtkAMReXParticlesReader.vtkAMReXParticlesReader_IsTypeOf_09(type);
		}

		// Token: 0x060067ED RID: 26605
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067EE RID: 26606 RVA: 0x000961F4 File Offset: 0x000943F4
		public new vtkAMReXParticlesReader NewInstance()
		{
			vtkAMReXParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXParticlesReader.vtkAMReXParticlesReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060067EF RID: 26607
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXParticlesReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067F0 RID: 26608 RVA: 0x00096250 File Offset: 0x00094450
		public new static vtkAMReXParticlesReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMReXParticlesReader vtkAMReXParticlesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXParticlesReader.vtkAMReXParticlesReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMReXParticlesReader = (vtkAMReXParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMReXParticlesReader.Register(null);
				}
			}
			return vtkAMReXParticlesReader;
		}

		// Token: 0x060067F1 RID: 26609
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMReXParticlesReader_SetController_13(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the controller to use. By default, the global
		/// vtkMultiProcessController will be used.
		/// </summary>
		// Token: 0x060067F2 RID: 26610 RVA: 0x000962D0 File Offset: 0x000944D0
		public void SetController(vtkMultiProcessController controller)
		{
			vtkAMReXParticlesReader.vtkAMReXParticlesReader_SetController_13(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x060067F3 RID: 26611
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMReXParticlesReader_SetParticleType_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Get/Set the particle type to read. By default, this is set to 'particles'.
		/// </summary>
		// Token: 0x060067F4 RID: 26612 RVA: 0x000962FF File Offset: 0x000944FF
		public void SetParticleType(string str)
		{
			vtkAMReXParticlesReader.vtkAMReXParticlesReader_SetParticleType_14(base.GetCppThis(), str);
		}

		// Token: 0x060067F5 RID: 26613
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMReXParticlesReader_SetPlotFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Get/Set the AMReX plotfile. Note this is a directory on the filesystem and
		/// not the file.
		/// </summary>
		// Token: 0x060067F6 RID: 26614 RVA: 0x0009630F File Offset: 0x0009450F
		public void SetPlotFileName(string fname)
		{
			vtkAMReXParticlesReader.vtkAMReXParticlesReader_SetPlotFileName_15(base.GetCppThis(), fname);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000939 RID: 2361
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMReXParticlesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093A RID: 2362
		public new static readonly string MRClassNameKey = "class vtkAMReXParticlesReader";
	}
}
