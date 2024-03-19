using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRSliceFilter
	///
	///
	///  A concrete instance of vtkOverlappingAMRAlgorithm which implements
	///  functionality for extracting slices from AMR data. Unlike the conventional
	///  slice filter, the output of this filter is a 2-D AMR dataset itself.
	/// </summary>
	// Token: 0x020004EB RID: 1259
	public class vtkAMRSliceFilter : vtkOverlappingAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E3B7 RID: 58295 RVA: 0x0013CF49 File Offset: 0x0013B149
		static vtkAMRSliceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRSliceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRSliceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3B8 RID: 58296 RVA: 0x0013CF71 File Offset: 0x0013B171
		public vtkAMRSliceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E3B9 RID: 58297
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRSliceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3BA RID: 58298 RVA: 0x0013CF80 File Offset: 0x0013B180
		public new static vtkAMRSliceFilter New()
		{
			vtkAMRSliceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRSliceFilter.vtkAMRSliceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3BB RID: 58299 RVA: 0x0013CFD4 File Offset: 0x0013B1D4
		public vtkAMRSliceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRSliceFilter.vtkAMRSliceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3BC RID: 58300 RVA: 0x0013D018 File Offset: 0x0013B218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E3BD RID: 58301
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRSliceFilter_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3BE RID: 58302 RVA: 0x0013D024 File Offset: 0x0013B224
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E3BF RID: 58303
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRSliceFilter_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3C0 RID: 58304 RVA: 0x0013D05C File Offset: 0x0013B25C
		public virtual int FillOutputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_FillOutputPortInformation_02(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E3C1 RID: 58305
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRSliceFilter_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3C2 RID: 58306 RVA: 0x0013D094 File Offset: 0x0013B294
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRSliceFilter.vtkAMRSliceFilter_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E3C3 RID: 58307
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAMRSliceFilter_GetMaxResolution_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum resolution used in this instance.
		/// </summary>
		// Token: 0x0600E3C4 RID: 58308 RVA: 0x0013D104 File Offset: 0x0013B304
		public virtual uint GetMaxResolution()
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_GetMaxResolution_04(base.GetCppThis());
		}

		// Token: 0x0600E3C5 RID: 58309
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRSliceFilter_GetNormal_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the Axis normal. The acceptable values are defined in the
		/// NormalTag enum.
		/// </summary>
		// Token: 0x0600E3C6 RID: 58310 RVA: 0x0013D124 File Offset: 0x0013B324
		public virtual int GetNormal()
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_GetNormal_05(base.GetCppThis());
		}

		// Token: 0x0600E3C7 RID: 58311
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRSliceFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3C8 RID: 58312 RVA: 0x0013D144 File Offset: 0x0013B344
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E3C9 RID: 58313
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRSliceFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3CA RID: 58314 RVA: 0x0013D164 File Offset: 0x0013B364
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600E3CB RID: 58315
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAMRSliceFilter_GetOffsetFromOrigin_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset-from-origin of the slicing plane.
		/// </summary>
		// Token: 0x0600E3CC RID: 58316 RVA: 0x0013D180 File Offset: 0x0013B380
		public virtual double GetOffsetFromOrigin()
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_GetOffsetFromOrigin_08(base.GetCppThis());
		}

		// Token: 0x0600E3CD RID: 58317
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRSliceFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3CE RID: 58318 RVA: 0x0013D1A0 File Offset: 0x0013B3A0
		public override int IsA(string type)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600E3CF RID: 58319
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRSliceFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3D0 RID: 58320 RVA: 0x0013D1C0 File Offset: 0x0013B3C0
		public new static int IsTypeOf(string type)
		{
			return vtkAMRSliceFilter.vtkAMRSliceFilter_IsTypeOf_10(type);
		}

		// Token: 0x0600E3D1 RID: 58321
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRSliceFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3D2 RID: 58322 RVA: 0x0013D1DC File Offset: 0x0013B3DC
		public new vtkAMRSliceFilter NewInstance()
		{
			vtkAMRSliceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRSliceFilter.vtkAMRSliceFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E3D3 RID: 58323
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRSliceFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3D4 RID: 58324 RVA: 0x0013D238 File Offset: 0x0013B438
		public new static vtkAMRSliceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAMRSliceFilter vtkAMRSliceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRSliceFilter.vtkAMRSliceFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRSliceFilter = (vtkAMRSliceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRSliceFilter.Register(null);
				}
			}
			return vtkAMRSliceFilter;
		}

		// Token: 0x0600E3D5 RID: 58325
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRSliceFilter_SetController_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3D6 RID: 58326 RVA: 0x0013D2B8 File Offset: 0x0013B4B8
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRSliceFilter.vtkAMRSliceFilter_SetController_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E3D7 RID: 58327
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRSliceFilter_SetMaxResolution_15(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the maximum resolution used in this instance.
		/// </summary>
		// Token: 0x0600E3D8 RID: 58328 RVA: 0x0013D2E7 File Offset: 0x0013B4E7
		public virtual void SetMaxResolution(uint _arg)
		{
			vtkAMRSliceFilter.vtkAMRSliceFilter_SetMaxResolution_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3D9 RID: 58329
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRSliceFilter_SetNormal_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Axis normal. The acceptable values are defined in the
		/// NormalTag enum.
		/// </summary>
		// Token: 0x0600E3DA RID: 58330 RVA: 0x0013D2F7 File Offset: 0x0013B4F7
		public virtual void SetNormal(int _arg)
		{
			vtkAMRSliceFilter.vtkAMRSliceFilter_SetNormal_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3DB RID: 58331
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRSliceFilter_SetOffsetFromOrigin_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the offset-from-origin of the slicing plane.
		/// </summary>
		// Token: 0x0600E3DC RID: 58332 RVA: 0x0013D307 File Offset: 0x0013B507
		public virtual void SetOffsetFromOrigin(double _arg)
		{
			vtkAMRSliceFilter.vtkAMRSliceFilter_SetOffsetFromOrigin_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B9 RID: 4281
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRSliceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010BA RID: 4282
		public new static readonly string MRClassNameKey = "class vtkAMRSliceFilter";

		/// <summary>
		/// Tags to identify normals along the X, Y and Z directions.
		/// </summary>
		// Token: 0x020004EC RID: 1260
		public enum NormalTag
		{
			/// <summary>enum member</summary>
			// Token: 0x040010BC RID: 4284
			X_NORMAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x040010BD RID: 4285
			Y_NORMAL,
			/// <summary>enum member</summary>
			// Token: 0x040010BE RID: 4286
			Z_NORMAL = 4
		}
	}
}
