using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractMapper
	/// </summary>
	/// <remarks>
	///    abstract class specifies interface to map data
	///
	/// vtkAbstractMapper is an abstract class to specify interface between data and
	/// graphics primitives or software rendering techniques. Subclasses of
	/// vtkAbstractMapper can be used for rendering 2D data, geometry, or volumetric
	/// data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractMapper3D vtkMapper vtkPolyDataMapper vtkVolumeMapper
	/// </seealso>
	// Token: 0x020000CA RID: 202
	public class vtkAbstractMapper : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002B40 RID: 11072 RVA: 0x0003FE79 File Offset: 0x0003E079
		static vtkAbstractMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002B41 RID: 11073 RVA: 0x0003FEA1 File Offset: 0x0003E0A1
		public vtkAbstractMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002B42 RID: 11074 RVA: 0x0003FEAF File Offset: 0x0003E0AF
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002B43 RID: 11075
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_AddClippingPlane_01(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Specify clipping planes to be applied when the data is mapped
		/// (at most 6 clipping planes can be specified).
		/// </summary>
		// Token: 0x06002B44 RID: 11076 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		public void AddClippingPlane(vtkPlane plane)
		{
			vtkAbstractMapper.vtkAbstractMapper_AddClippingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06002B45 RID: 11077
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_GetAbstractScalars_02(HandleRef input, int scalarMode, int arrayAccessMode, int arrayId, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Internal helper function for getting the active scalars as an
		/// abstract array. The scalar mode indicates where the scalars come
		/// from.  The cellFlag is a return value that is set when the
		/// scalars actually are cell scalars.  (0 for point scalars, 1 for
		/// cell scalars, 2 for field scalars) The arrayAccessMode is used to
		/// indicate how to retrieve the scalars from field data, per id or
		/// per name (if the scalarMode indicates that).
		/// </summary>
		// Token: 0x06002B46 RID: 11078 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		public static vtkAbstractArray GetAbstractScalars(vtkDataSet input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetAbstractScalars_02((input == null) ? default(HandleRef) : input.GetCppThis(), scalarMode, arrayAccessMode, arrayId, arrayName, ref cellFlag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x06002B47 RID: 11079
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_GetClippingPlanes_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the vtkPlaneCollection which specifies the
		/// clipping planes.
		/// </summary>
		// Token: 0x06002B48 RID: 11080 RVA: 0x0003FF74 File Offset: 0x0003E174
		public virtual vtkPlaneCollection GetClippingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetClippingPlanes_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		// Token: 0x06002B49 RID: 11081
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_GetGhostArray_04(HandleRef input, int scalarMode, ref byte ghostsToSkip, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghost array associated with the corresponding scalar mode, if present.
		/// If no ghost array is available, this method returns `nullptr`. `ghostsToSkip` is an output,
		/// and is set to the bit mask associated with the ghost array in the `vtkFieldData` in which
		/// the ghost array lives. This bit mask can be ignored if `nullptr` is returned.
		///
		/// @sa
		/// vtkFieldData
		/// vtkDataSetAttributes
		/// vtkCellData
		/// vtkPointData
		/// </summary>
		// Token: 0x06002B4A RID: 11082 RVA: 0x0003FFE4 File Offset: 0x0003E1E4
		public static vtkUnsignedCharArray GetGhostArray(vtkDataSet input, int scalarMode, ref byte ghostsToSkip)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetGhostArray_04((input == null) ? default(HandleRef) : input.GetCppThis(), scalarMode, ref ghostsToSkip, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06002B4B RID: 11083
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAbstractMapper_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Override Modifiedtime as we have added Clipping planes
		/// </summary>
		// Token: 0x06002B4C RID: 11084 RVA: 0x00040068 File Offset: 0x0003E268
		public override ulong GetMTime()
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06002B4D RID: 11085
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper_GetNumberOfClippingPlanes_06(HandleRef pThis);

		/// <summary>
		/// Get the number of clipping planes.
		/// </summary>
		// Token: 0x06002B4E RID: 11086 RVA: 0x00040088 File Offset: 0x0003E288
		public int GetNumberOfClippingPlanes()
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetNumberOfClippingPlanes_06(base.GetCppThis());
		}

		// Token: 0x06002B4F RID: 11087
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractMapper_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B50 RID: 11088 RVA: 0x000400A8 File Offset: 0x0003E2A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06002B51 RID: 11089
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractMapper_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B52 RID: 11090 RVA: 0x000400C8 File Offset: 0x0003E2C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06002B53 RID: 11091
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_GetScalars_09(HandleRef input, int scalarMode, int arrayAccessMode, int arrayId, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Internal helper function for getting the active scalars. The scalar
		/// mode indicates where the scalars come from.  The cellFlag is a
		/// return value that is set when the scalars actually are cell scalars.
		/// (0 for point scalars, 1 for cell scalars, 2 for field scalars)
		/// The arrayAccessMode is used to indicate how to retrieve the scalars from
		/// field data, per id or per name (if the scalarMode indicates that).
		/// </summary>
		// Token: 0x06002B54 RID: 11092 RVA: 0x000400E4 File Offset: 0x0003E2E4
		public static vtkDataArray GetScalars(vtkDataSet input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetScalars_09((input == null) ? default(HandleRef) : input.GetCppThis(), scalarMode, arrayAccessMode, arrayId, arrayName, ref cellFlag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06002B55 RID: 11093
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractMapper_GetTimeToDraw_10(HandleRef pThis);

		/// <summary>
		/// Get the time required to draw the geometry last time it was rendered
		/// </summary>
		// Token: 0x06002B56 RID: 11094 RVA: 0x0004016C File Offset: 0x0003E36C
		public virtual double GetTimeToDraw()
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetTimeToDraw_10(base.GetCppThis());
		}

		// Token: 0x06002B57 RID: 11095
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B58 RID: 11096 RVA: 0x0004018C File Offset: 0x0003E38C
		public override int IsA(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06002B59 RID: 11097
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B5A RID: 11098 RVA: 0x000401AC File Offset: 0x0003E3AC
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_IsTypeOf_12(type);
		}

		// Token: 0x06002B5B RID: 11099
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B5C RID: 11100 RVA: 0x000401C8 File Offset: 0x0003E3C8
		public new vtkAbstractMapper NewInstance()
		{
			vtkAbstractMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002B5D RID: 11101
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002B5E RID: 11102 RVA: 0x00040224 File Offset: 0x0003E424
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractMapper.vtkAbstractMapper_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002B5F RID: 11103
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_RemoveAllClippingPlanes_15(HandleRef pThis);

		/// <summary>
		/// Specify clipping planes to be applied when the data is mapped
		/// (at most 6 clipping planes can be specified).
		/// </summary>
		// Token: 0x06002B60 RID: 11104 RVA: 0x00040253 File Offset: 0x0003E453
		public void RemoveAllClippingPlanes()
		{
			vtkAbstractMapper.vtkAbstractMapper_RemoveAllClippingPlanes_15(base.GetCppThis());
		}

		// Token: 0x06002B61 RID: 11105
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_RemoveClippingPlane_16(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Specify clipping planes to be applied when the data is mapped
		/// (at most 6 clipping planes can be specified).
		/// </summary>
		// Token: 0x06002B62 RID: 11106 RVA: 0x00040264 File Offset: 0x0003E464
		public void RemoveClippingPlane(vtkPlane plane)
		{
			vtkAbstractMapper.vtkAbstractMapper_RemoveClippingPlane_16(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06002B63 RID: 11107
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B64 RID: 11108 RVA: 0x00040294 File Offset: 0x0003E494
		public new static vtkAbstractMapper SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractMapper vtkAbstractMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper.Register(null);
				}
			}
			return vtkAbstractMapper;
		}

		// Token: 0x06002B65 RID: 11109
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_SetClippingPlanes_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the vtkPlaneCollection which specifies the
		/// clipping planes.
		/// </summary>
		// Token: 0x06002B66 RID: 11110 RVA: 0x00040314 File Offset: 0x0003E514
		public virtual void SetClippingPlanes(vtkPlaneCollection arg0)
		{
			vtkAbstractMapper.vtkAbstractMapper_SetClippingPlanes_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002B67 RID: 11111
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_SetClippingPlanes_19(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// An alternative way to set clipping planes: use up to six planes found
		/// in the supplied instance of the implicit function vtkPlanes.
		/// </summary>
		// Token: 0x06002B68 RID: 11112 RVA: 0x00040344 File Offset: 0x0003E544
		public void SetClippingPlanes(vtkPlanes planes)
		{
			vtkAbstractMapper.vtkAbstractMapper_SetClippingPlanes_19(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x06002B69 RID: 11113
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper_ShallowCopy_20(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x06002B6A RID: 11114 RVA: 0x00040374 File Offset: 0x0003E574
		public virtual void ShallowCopy(vtkAbstractMapper m)
		{
			vtkAbstractMapper.vtkAbstractMapper_ShallowCopy_20(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000586 RID: 1414
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000587 RID: 1415
		public new static readonly string MRClassNameKey = "class vtkAbstractMapper";
	}
}
