using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRBaseParticlesReader
	/// </summary>
	/// <remarks>
	///    An abstract base class that implements all the common functionality for
	///  all particle readers.
	/// </remarks>
	// Token: 0x02000221 RID: 545
	public abstract class vtkAMRBaseParticlesReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060066C1 RID: 26305 RVA: 0x000942D7 File Offset: 0x000924D7
		static vtkAMRBaseParticlesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRBaseParticlesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRBaseParticlesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060066C2 RID: 26306 RVA: 0x000942FF File Offset: 0x000924FF
		public vtkAMRBaseParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060066C3 RID: 26307 RVA: 0x0009430D File Offset: 0x0009250D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060066C4 RID: 26308
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_FilterLocationOff_01(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get for filter location and boolean macro
		/// </summary>
		// Token: 0x060066C5 RID: 26309 RVA: 0x00094318 File Offset: 0x00092518
		public virtual void FilterLocationOff()
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_FilterLocationOff_01(base.GetCppThis());
		}

		// Token: 0x060066C6 RID: 26310
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_FilterLocationOn_02(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get for filter location and boolean macro
		/// </summary>
		// Token: 0x060066C7 RID: 26311 RVA: 0x00094327 File Offset: 0x00092527
		public virtual void FilterLocationOn()
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_FilterLocationOn_02(base.GetCppThis());
		}

		// Token: 0x060066C8 RID: 26312
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set &amp; Get the multi-process controller.
		/// </summary>
		// Token: 0x060066C9 RID: 26313 RVA: 0x00094338 File Offset: 0x00092538
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060066CA RID: 26314
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the particle array status.
		/// </summary>
		// Token: 0x060066CB RID: 26315 RVA: 0x000943A8 File Offset: 0x000925A8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060066CC RID: 26316
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_GetFilterLocation_05(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get for filter location and boolean macro
		/// </summary>
		// Token: 0x060066CD RID: 26317 RVA: 0x000943E4 File Offset: 0x000925E4
		public virtual int GetFilterLocation()
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetFilterLocation_05(base.GetCppThis());
		}

		// Token: 0x060066CE RID: 26318
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_GetFrequency_06(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get the frequency.
		/// </summary>
		// Token: 0x060066CF RID: 26319 RVA: 0x00094404 File Offset: 0x00092604
		public virtual int GetFrequency()
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetFrequency_06(base.GetCppThis());
		}

		// Token: 0x060066D0 RID: 26320
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066D1 RID: 26321 RVA: 0x00094424 File Offset: 0x00092624
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060066D2 RID: 26322
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066D3 RID: 26323 RVA: 0x00094444 File Offset: 0x00092644
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060066D4 RID: 26324
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_GetNumberOfParticleArrays_09(HandleRef pThis);

		/// <summary>
		/// Get the number of particles arrays available in the input.
		/// </summary>
		// Token: 0x060066D5 RID: 26325 RVA: 0x00094460 File Offset: 0x00092660
		public int GetNumberOfParticleArrays()
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetNumberOfParticleArrays_09(base.GetCppThis());
		}

		// Token: 0x060066D6 RID: 26326
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_GetParticleArrayName_10(HandleRef pThis, int index);

		/// <summary>
		/// Get the particle array name of the array associated with the given
		/// index.
		/// </summary>
		// Token: 0x060066D7 RID: 26327 RVA: 0x00094480 File Offset: 0x00092680
		public string GetParticleArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetParticleArrayName_10(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060066D8 RID: 26328
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_GetParticleArrayStatus_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the particle array status.
		/// </summary>
		// Token: 0x060066D9 RID: 26329 RVA: 0x000944BC File Offset: 0x000926BC
		public int GetParticleArrayStatus(string name)
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetParticleArrayStatus_11(base.GetCppThis(), name);
		}

		// Token: 0x060066DA RID: 26330
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_GetParticleDataArraySelection_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x060066DB RID: 26331 RVA: 0x000944DC File Offset: 0x000926DC
		public virtual vtkDataArraySelection GetParticleDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetParticleDataArraySelection_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060066DC RID: 26332
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_GetTotalNumberOfParticles_13(HandleRef pThis);

		/// <summary>
		/// Returns the total number of particles
		/// </summary>
		// Token: 0x060066DD RID: 26333 RVA: 0x0009454C File Offset: 0x0009274C
		public virtual int GetTotalNumberOfParticles()
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_GetTotalNumberOfParticles_13(base.GetCppThis());
		}

		// Token: 0x060066DE RID: 26334
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066DF RID: 26335 RVA: 0x0009456C File Offset: 0x0009276C
		public override int IsA(string type)
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060066E0 RID: 26336
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseParticlesReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066E1 RID: 26337 RVA: 0x0009458C File Offset: 0x0009278C
		public new static int IsTypeOf(string type)
		{
			return vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_IsTypeOf_15(type);
		}

		// Token: 0x060066E2 RID: 26338
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066E3 RID: 26339 RVA: 0x000945A8 File Offset: 0x000927A8
		public new vtkAMRBaseParticlesReader NewInstance()
		{
			vtkAMRBaseParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRBaseParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060066E4 RID: 26340
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseParticlesReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066E5 RID: 26341 RVA: 0x00094604 File Offset: 0x00092804
		public new static vtkAMRBaseParticlesReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMRBaseParticlesReader vtkAMRBaseParticlesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRBaseParticlesReader = (vtkAMRBaseParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRBaseParticlesReader.Register(null);
				}
			}
			return vtkAMRBaseParticlesReader;
		}

		// Token: 0x060066E6 RID: 26342
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetController_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set &amp; Get the multi-process controller.
		/// </summary>
		// Token: 0x060066E7 RID: 26343 RVA: 0x00094684 File Offset: 0x00092884
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetController_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060066E8 RID: 26344
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Get/Set whether the particle array status.
		/// </summary>
		// Token: 0x060066E9 RID: 26345 RVA: 0x000946B3 File Offset: 0x000928B3
		public virtual void SetFileName(string fileName)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetFileName_19(base.GetCppThis(), fileName);
		}

		// Token: 0x060066EA RID: 26346
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetFilterLocation_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set &amp; Get for filter location and boolean macro
		/// </summary>
		// Token: 0x060066EB RID: 26347 RVA: 0x000946C3 File Offset: 0x000928C3
		public virtual void SetFilterLocation(int _arg)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetFilterLocation_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060066EC RID: 26348
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetFrequency_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set &amp; Get the frequency.
		/// </summary>
		// Token: 0x060066ED RID: 26349 RVA: 0x000946D3 File Offset: 0x000928D3
		public virtual void SetFrequency(int _arg)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetFrequency_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060066EE RID: 26350
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetMaxLocation_22(HandleRef pThis, double maxx, double maxy, double maxz);

		/// <summary>
		/// Sets the max location
		/// </summary>
		// Token: 0x060066EF RID: 26351 RVA: 0x000946E3 File Offset: 0x000928E3
		public void SetMaxLocation(double maxx, double maxy, double maxz)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetMaxLocation_22(base.GetCppThis(), maxx, maxy, maxz);
		}

		// Token: 0x060066F0 RID: 26352
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetMinLocation_23(HandleRef pThis, double minx, double miny, double minz);

		/// <summary>
		/// Sets the min location
		/// </summary>
		// Token: 0x060066F1 RID: 26353 RVA: 0x000946F5 File Offset: 0x000928F5
		public void SetMinLocation(double minx, double miny, double minz)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetMinLocation_23(base.GetCppThis(), minx, miny, minz);
		}

		// Token: 0x060066F2 RID: 26354
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseParticlesReader_SetParticleArrayStatus_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the particle array status.
		/// </summary>
		// Token: 0x060066F3 RID: 26355 RVA: 0x00094707 File Offset: 0x00092907
		public void SetParticleArrayStatus(string name, int status)
		{
			vtkAMRBaseParticlesReader.vtkAMRBaseParticlesReader_SetParticleArrayStatus_24(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000929 RID: 2345
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRBaseParticlesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092A RID: 2346
		public new static readonly string MRClassNameKey = "class vtkAMRBaseParticlesReader";
	}
}
