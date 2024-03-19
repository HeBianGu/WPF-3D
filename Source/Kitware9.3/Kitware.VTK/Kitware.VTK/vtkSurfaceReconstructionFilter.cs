using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSurfaceReconstructionFilter
	/// </summary>
	/// <remarks>
	///    reconstructs a surface from unorganized points
	///
	/// vtkSurfaceReconstructionFilter takes a list of points assumed to lie on
	/// the surface of a solid 3D object. A signed measure of the distance to the
	/// surface is computed and sampled on a regular grid. The grid can then be
	/// contoured at zero to extract the surface. The default values for
	/// neighborhood size and sample spacing should give reasonable results for
	/// most uses but can be set if desired. This procedure is based on the PhD
	/// work of Hugues Hoppe: http://www.research.microsoft.com/~hoppe
	/// </remarks>
	// Token: 0x020003EA RID: 1002
	public class vtkSurfaceReconstructionFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C017 RID: 49175 RVA: 0x0010B959 File Offset: 0x00109B59
		static vtkSurfaceReconstructionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceReconstructionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceReconstructionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C018 RID: 49176 RVA: 0x0010B981 File Offset: 0x00109B81
		public vtkSurfaceReconstructionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C019 RID: 49177
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with NeighborhoodSize=20.
		/// </summary>
		// Token: 0x0600C01A RID: 49178 RVA: 0x0010B990 File Offset: 0x00109B90
		public new static vtkSurfaceReconstructionFilter New()
		{
			vtkSurfaceReconstructionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with NeighborhoodSize=20.
		/// </summary>
		// Token: 0x0600C01B RID: 49179 RVA: 0x0010B9E4 File Offset: 0x00109BE4
		public vtkSurfaceReconstructionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C01C RID: 49180 RVA: 0x0010BA28 File Offset: 0x00109C28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C01D RID: 49181
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(HandleRef pThis);

		/// <summary>
		/// Specify the number of neighbors each point has, used for estimating the
		/// local surface orientation.  The default value of 20 should be OK for
		/// most applications, higher values can be specified if the spread of
		/// points is uneven. Values as low as 10 may yield adequate results for
		/// some surfaces. Higher values cause the algorithm to take longer. Higher
		/// values will cause errors on sharp boundaries.
		/// </summary>
		// Token: 0x0600C01E RID: 49182 RVA: 0x0010BA34 File Offset: 0x00109C34
		public virtual int GetNeighborhoodSize()
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(base.GetCppThis());
		}

		// Token: 0x0600C01F RID: 49183
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C020 RID: 49184 RVA: 0x0010BA54 File Offset: 0x00109C54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C021 RID: 49185
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C022 RID: 49186 RVA: 0x0010BA74 File Offset: 0x00109C74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C023 RID: 49187
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSurfaceReconstructionFilter_GetSampleSpacing_04(HandleRef pThis);

		/// <summary>
		/// Specify the spacing of the 3D sampling grid. If not set, a
		/// reasonable guess will be made.
		/// </summary>
		// Token: 0x0600C024 RID: 49188 RVA: 0x0010BA90 File Offset: 0x00109C90
		public virtual double GetSampleSpacing()
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetSampleSpacing_04(base.GetCppThis());
		}

		// Token: 0x0600C025 RID: 49189
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceReconstructionFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C026 RID: 49190 RVA: 0x0010BAB0 File Offset: 0x00109CB0
		public override int IsA(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C027 RID: 49191
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSurfaceReconstructionFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C028 RID: 49192 RVA: 0x0010BAD0 File Offset: 0x00109CD0
		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_IsTypeOf_06(type);
		}

		// Token: 0x0600C029 RID: 49193
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C02A RID: 49194 RVA: 0x0010BAEC File Offset: 0x00109CEC
		public new vtkSurfaceReconstructionFilter NewInstance()
		{
			vtkSurfaceReconstructionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C02B RID: 49195
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C02C RID: 49196 RVA: 0x0010BB48 File Offset: 0x00109D48
		public new static vtkSurfaceReconstructionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceReconstructionFilter vtkSurfaceReconstructionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceReconstructionFilter = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceReconstructionFilter.Register(null);
				}
			}
			return vtkSurfaceReconstructionFilter;
		}

		// Token: 0x0600C02D RID: 49197
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceReconstructionFilter_SetNeighborhoodSize_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of neighbors each point has, used for estimating the
		/// local surface orientation.  The default value of 20 should be OK for
		/// most applications, higher values can be specified if the spread of
		/// points is uneven. Values as low as 10 may yield adequate results for
		/// some surfaces. Higher values cause the algorithm to take longer. Higher
		/// values will cause errors on sharp boundaries.
		/// </summary>
		// Token: 0x0600C02E RID: 49198 RVA: 0x0010BBC7 File Offset: 0x00109DC7
		public virtual void SetNeighborhoodSize(int _arg)
		{
			vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SetNeighborhoodSize_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C02F RID: 49199
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSurfaceReconstructionFilter_SetSampleSpacing_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the spacing of the 3D sampling grid. If not set, a
		/// reasonable guess will be made.
		/// </summary>
		// Token: 0x0600C030 RID: 49200 RVA: 0x0010BBD7 File Offset: 0x00109DD7
		public virtual void SetSampleSpacing(double _arg)
		{
			vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SetSampleSpacing_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E41 RID: 3649
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceReconstructionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E42 RID: 3650
		public new static readonly string MRClassNameKey = "class vtkSurfaceReconstructionFilter";
	}
}
