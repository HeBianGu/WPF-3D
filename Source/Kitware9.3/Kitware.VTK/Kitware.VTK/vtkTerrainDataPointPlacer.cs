using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTerrainDataPointPlacer
	/// </summary>
	/// <remarks>
	///    Place points on terrain data
	///
	///
	/// vtkTerrainDataPointPlacer dictates the placement of points on height field
	/// data. The class takes as input the list of props that represent the terrain
	/// in a rendered scene. A height offset can be specified to dicatate the
	/// placement of points at a certain height above the surface.
	///
	/// @par Usage:
	/// A typical usage of this class is as follows:
	/// <code>
	/// pointPlacer-&gt;AddProp(demActor);    // the actor(s) containing the terrain.
	/// rep-&gt;SetPointPlacer(pointPlacer);
	/// pointPlacer-&gt;SetHeightOffset( 100 );
	/// </code>
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointPlacer vtkTerrainContourLineInterpolator
	/// </seealso>
	// Token: 0x02000385 RID: 901
	public class vtkTerrainDataPointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A437 RID: 42039 RVA: 0x000E8BE8 File Offset: 0x000E6DE8
		static vtkTerrainDataPointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTerrainDataPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainDataPointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A438 RID: 42040 RVA: 0x000E8C10 File Offset: 0x000E6E10
		public vtkTerrainDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A439 RID: 42041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A43A RID: 42042 RVA: 0x000E8C20 File Offset: 0x000E6E20
		public new static vtkTerrainDataPointPlacer New()
		{
			vtkTerrainDataPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A43B RID: 42043 RVA: 0x000E8C74 File Offset: 0x000E6E74
		public vtkTerrainDataPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A43C RID: 42044 RVA: 0x000E8CB8 File Offset: 0x000E6EB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A43D RID: 42045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTerrainDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A43E RID: 42046 RVA: 0x000E8CC4 File Offset: 0x000E6EC4
		public virtual void AddProp(vtkProp arg0)
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A43F RID: 42047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position in pixel coordinates,
		/// compute the world position and orientation where this point
		/// will be placed. This method is typically used by the
		/// representation to place the point initially.
		/// For the Terrain point placer this computes world points that
		/// lie at the specified height above the terrain.
		/// </summary>
		// Token: 0x0600A440 RID: 42048 RVA: 0x000E8CF4 File Offset: 0x000E6EF4
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x0600A441 RID: 42049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point.
		/// </summary>
		// Token: 0x0600A442 RID: 42050 RVA: 0x000E8D2C File Offset: 0x000E6F2C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x0600A443 RID: 42051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTerrainDataPointPlacer_GetHeightOffset_04(HandleRef pThis);

		/// <summary>
		/// This is the height above (or below) the terrain that the dictated
		/// point should be placed. Positive values indicate distances above the
		/// terrain; negative values indicate distances below the terrain. The
		/// default is 0.0.
		/// </summary>
		// Token: 0x0600A444 RID: 42052 RVA: 0x000E8D68 File Offset: 0x000E6F68
		public virtual double GetHeightOffset()
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetHeightOffset_04(base.GetCppThis());
		}

		// Token: 0x0600A445 RID: 42053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A446 RID: 42054 RVA: 0x000E8D88 File Offset: 0x000E6F88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A447 RID: 42055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A448 RID: 42056 RVA: 0x000E8DA8 File Offset: 0x000E6FA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A449 RID: 42057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainDataPointPlacer_GetPropPicker_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Prop picker.
		/// </summary>
		// Token: 0x0600A44A RID: 42058 RVA: 0x000E8DC4 File Offset: 0x000E6FC4
		public virtual vtkPropPicker GetPropPicker()
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetPropPicker_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropPicker = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropPicker.Register(null);
				}
			}
			return vtkPropPicker;
		}

		// Token: 0x0600A44B RID: 42059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A44C RID: 42060 RVA: 0x000E8E34 File Offset: 0x000E7034
		public override int IsA(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A44D RID: 42061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A44E RID: 42062 RVA: 0x000E8E54 File Offset: 0x000E7054
		public new static int IsTypeOf(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_IsTypeOf_09(type);
		}

		// Token: 0x0600A44F RID: 42063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainDataPointPlacer_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A450 RID: 42064 RVA: 0x000E8E70 File Offset: 0x000E7070
		public new vtkTerrainDataPointPlacer NewInstance()
		{
			vtkTerrainDataPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A451 RID: 42065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTerrainDataPointPlacer_RemoveAllProps_12(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A452 RID: 42066 RVA: 0x000E8ECA File Offset: 0x000E70CA
		public virtual void RemoveAllProps()
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_RemoveAllProps_12(base.GetCppThis());
		}

		// Token: 0x0600A453 RID: 42067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTerrainDataPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600A454 RID: 42068 RVA: 0x000E8EDC File Offset: 0x000E70DC
		public new static vtkTerrainDataPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkTerrainDataPointPlacer vtkTerrainDataPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTerrainDataPointPlacer = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTerrainDataPointPlacer.Register(null);
				}
			}
			return vtkTerrainDataPointPlacer;
		}

		// Token: 0x0600A455 RID: 42069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTerrainDataPointPlacer_SetHeightOffset_14(HandleRef pThis, double _arg);

		/// <summary>
		/// This is the height above (or below) the terrain that the dictated
		/// point should be placed. Positive values indicate distances above the
		/// terrain; negative values indicate distances below the terrain. The
		/// default is 0.0.
		/// </summary>
		// Token: 0x0600A456 RID: 42070 RVA: 0x000E8F5B File Offset: 0x000E715B
		public virtual void SetHeightOffset(double _arg)
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_SetHeightOffset_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A457 RID: 42071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_ValidateDisplayPosition_15(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		/// <summary>
		/// Given a display position, check the validity of this position.
		/// </summary>
		// Token: 0x0600A458 RID: 42072 RVA: 0x000E8F6C File Offset: 0x000E716C
		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateDisplayPosition_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		// Token: 0x0600A459 RID: 42073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_16(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Given a world position check the validity of this
		/// position according to the constraints of the placer
		/// </summary>
		// Token: 0x0600A45A RID: 42074 RVA: 0x000E8FA4 File Offset: 0x000E71A4
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateWorldPosition_16(base.GetCppThis(), worldPos);
		}

		// Token: 0x0600A45B RID: 42075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a world position and a world orientation,
		/// validate it according to the constraints of the placer.
		/// </summary>
		// Token: 0x0600A45C RID: 42076 RVA: 0x000E8FC4 File Offset: 0x000E71C4
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateWorldPosition_17(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D21 RID: 3361
		public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainDataPointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D22 RID: 3362
		public new static readonly string MRClassNameKey = "class vtkTerrainDataPointPlacer";
	}
}
