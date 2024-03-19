using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeContourSpectrumFilter
	/// </summary>
	/// <remarks>
	///    compute an approximation of the
	/// volume contour signature (evolution of the volume of the input tet-mesh
	/// along an arc of the Reeb graph).
	///
	/// The filter takes a vtkUnstructuredGrid as an input (port 0), along with a
	/// vtkReebGraph (port 1).
	/// The Reeb graph arc to consider can be specified with SetArcId() (default: 0).
	/// The number of (evenly distributed) samples of the signature can be defined
	/// with SetNumberOfSamples() (default value: 100).
	/// The filter will first try to pull as a scalar field the vtkDataArray with Id
	/// 'FieldId' of the vtkUnstructuredGrid, see SetFieldId (default: 0). The
	/// filter will abort if this field does not exist.
	///
	/// The filter outputs a vtkTable with the volume contour signature
	/// approximation, each sample being evenly distributed in the function span of
	/// the arc.
	///
	/// This filter is a typical example for designing your own contour signature
	/// filter (with customized metrics). It also shows typical vtkReebGraph
	/// traversals.
	///
	/// Reference:
	/// C. Bajaj, V. Pascucci, D. Schikore,
	/// "The contour spectrum",
	/// IEEE Visualization, 167-174, 1997.
	/// </remarks>
	// Token: 0x020008F7 RID: 2295
	public class vtkVolumeContourSpectrumFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017B35 RID: 97077 RVA: 0x00213C2B File Offset: 0x00211E2B
		static vtkVolumeContourSpectrumFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeContourSpectrumFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeContourSpectrumFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017B36 RID: 97078 RVA: 0x00213C53 File Offset: 0x00211E53
		public vtkVolumeContourSpectrumFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017B37 RID: 97079
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B38 RID: 97080 RVA: 0x00213C64 File Offset: 0x00211E64
		public new static vtkVolumeContourSpectrumFilter New()
		{
			vtkVolumeContourSpectrumFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B39 RID: 97081 RVA: 0x00213CB8 File Offset: 0x00211EB8
		public vtkVolumeContourSpectrumFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017B3A RID: 97082 RVA: 0x00213CFC File Offset: 0x00211EFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017B3B RID: 97083
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeContourSpectrumFilter_GetArcId_01(HandleRef pThis);

		/// <summary>
		/// Set the arc Id for which the contour signature has to be computed.
		/// Default value: 0
		/// </summary>
		// Token: 0x06017B3C RID: 97084 RVA: 0x00213D08 File Offset: 0x00211F08
		public virtual long GetArcId()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetArcId_01(base.GetCppThis());
		}

		// Token: 0x06017B3D RID: 97085
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeContourSpectrumFilter_GetFieldId_02(HandleRef pThis);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x06017B3E RID: 97086 RVA: 0x00213D28 File Offset: 0x00211F28
		public virtual long GetFieldId()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetFieldId_02(base.GetCppThis());
		}

		// Token: 0x06017B3F RID: 97087
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B40 RID: 97088 RVA: 0x00213D48 File Offset: 0x00211F48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06017B41 RID: 97089
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B42 RID: 97090 RVA: 0x00213D68 File Offset: 0x00211F68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06017B43 RID: 97091
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeContourSpectrumFilter_GetNumberOfSamples_05(HandleRef pThis);

		/// <summary>
		/// Set the number of samples in the output signature
		/// Default value: 100
		/// </summary>
		// Token: 0x06017B44 RID: 97092 RVA: 0x00213D84 File Offset: 0x00211F84
		public virtual int GetNumberOfSamples()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetNumberOfSamples_05(base.GetCppThis());
		}

		// Token: 0x06017B45 RID: 97093
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x06017B46 RID: 97094 RVA: 0x00213DA4 File Offset: 0x00211FA4
		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06017B47 RID: 97095
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeContourSpectrumFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B48 RID: 97096 RVA: 0x00213E14 File Offset: 0x00212014
		public override int IsA(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06017B49 RID: 97097
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeContourSpectrumFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B4A RID: 97098 RVA: 0x00213E34 File Offset: 0x00212034
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_IsTypeOf_08(type);
		}

		// Token: 0x06017B4B RID: 97099
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B4C RID: 97100 RVA: 0x00213E50 File Offset: 0x00212050
		public new vtkVolumeContourSpectrumFilter NewInstance()
		{
			vtkVolumeContourSpectrumFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B4D RID: 97101
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B4E RID: 97102 RVA: 0x00213EAC File Offset: 0x002120AC
		public new static vtkVolumeContourSpectrumFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeContourSpectrumFilter vtkVolumeContourSpectrumFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeContourSpectrumFilter = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeContourSpectrumFilter.Register(null);
				}
			}
			return vtkVolumeContourSpectrumFilter;
		}

		// Token: 0x06017B4F RID: 97103
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeContourSpectrumFilter_SetArcId_12(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the arc Id for which the contour signature has to be computed.
		/// Default value: 0
		/// </summary>
		// Token: 0x06017B50 RID: 97104 RVA: 0x00213F2B File Offset: 0x0021212B
		public virtual void SetArcId(long _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetArcId_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06017B51 RID: 97105
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeContourSpectrumFilter_SetFieldId_13(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x06017B52 RID: 97106 RVA: 0x00213F3B File Offset: 0x0021213B
		public virtual void SetFieldId(long _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetFieldId_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06017B53 RID: 97107
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeContourSpectrumFilter_SetNumberOfSamples_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of samples in the output signature
		/// Default value: 100
		/// </summary>
		// Token: 0x06017B54 RID: 97108 RVA: 0x00213F4B File Offset: 0x0021214B
		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetNumberOfSamples_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6D RID: 6765
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeContourSpectrumFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6E RID: 6766
		public new static readonly string MRClassNameKey = "class vtkVolumeContourSpectrumFilter";
	}
}
