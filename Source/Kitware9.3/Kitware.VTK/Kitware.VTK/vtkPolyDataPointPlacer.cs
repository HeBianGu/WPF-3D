using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataPointPlacer
	/// </summary>
	/// <remarks>
	///    Base class to place points given constraints on polygonal data
	///
	///
	/// vtkPolyDataPointPlacer is a base class to place points on the surface of
	/// polygonal data.
	///
	/// @par Usage:
	/// The actors that render polygonal data and wish to be considered
	/// for placement by this placer are added to the list as
	/// <code>
	/// placer-&gt;AddProp( polyDataActor );
	/// </code>
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolygonalSurfacePointPlacer
	/// </seealso>
	// Token: 0x02000357 RID: 855
	public class vtkPolyDataPointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009BBC RID: 39868 RVA: 0x000DC7EC File Offset: 0x000DA9EC
		static vtkPolyDataPointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009BBD RID: 39869 RVA: 0x000DC814 File Offset: 0x000DAA14
		public vtkPolyDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009BBE RID: 39870
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009BBF RID: 39871 RVA: 0x000DC824 File Offset: 0x000DAA24
		public new static vtkPolyDataPointPlacer New()
		{
			vtkPolyDataPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009BC0 RID: 39872 RVA: 0x000DC878 File Offset: 0x000DAA78
		public vtkPolyDataPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009BC1 RID: 39873 RVA: 0x000DC8BC File Offset: 0x000DAABC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009BC2 RID: 39874
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BC3 RID: 39875 RVA: 0x000DC8C8 File Offset: 0x000DAAC8
		public virtual void AddProp(vtkProp arg0)
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009BC4 RID: 39876
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position in pixel coordinates,
		/// compute the world position and orientation where this point
		/// will be placed. This method is typically used by the
		/// representation to place the point initially.
		/// For the Terrain point placer this computes world points that
		/// lie at the specified height above the terrain.
		/// </summary>
		// Token: 0x06009BC5 RID: 39877 RVA: 0x000DC8F8 File Offset: 0x000DAAF8
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06009BC6 RID: 39878
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point.
		/// </summary>
		// Token: 0x06009BC7 RID: 39879 RVA: 0x000DC930 File Offset: 0x000DAB30
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x06009BC8 RID: 39880
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BC9 RID: 39881 RVA: 0x000DC96C File Offset: 0x000DAB6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06009BCA RID: 39882
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BCB RID: 39883 RVA: 0x000DC98C File Offset: 0x000DAB8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06009BCC RID: 39884
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_GetNumberOfProps_06(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BCD RID: 39885 RVA: 0x000DC9A8 File Offset: 0x000DABA8
		public int GetNumberOfProps()
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetNumberOfProps_06(base.GetCppThis());
		}

		// Token: 0x06009BCE RID: 39886
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointPlacer_GetPropPicker_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Prop picker.
		/// </summary>
		// Token: 0x06009BCF RID: 39887 RVA: 0x000DC9C8 File Offset: 0x000DABC8
		public virtual vtkPropPicker GetPropPicker()
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetPropPicker_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009BD0 RID: 39888
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_HasProp_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BD1 RID: 39889 RVA: 0x000DCA38 File Offset: 0x000DAC38
		public int HasProp(vtkProp arg0)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_HasProp_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009BD2 RID: 39890
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BD3 RID: 39891 RVA: 0x000DCA6C File Offset: 0x000DAC6C
		public override int IsA(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06009BD4 RID: 39892
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BD5 RID: 39893 RVA: 0x000DCA8C File Offset: 0x000DAC8C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_IsTypeOf_10(type);
		}

		// Token: 0x06009BD6 RID: 39894
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BD7 RID: 39895 RVA: 0x000DCAA8 File Offset: 0x000DACA8
		public new vtkPolyDataPointPlacer NewInstance()
		{
			vtkPolyDataPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009BD8 RID: 39896
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointPlacer_RemoveAllProps_13(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BD9 RID: 39897 RVA: 0x000DCB02 File Offset: 0x000DAD02
		public virtual void RemoveAllProps()
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_RemoveAllProps_13(base.GetCppThis());
		}

		// Token: 0x06009BDA RID: 39898
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointPlacer_RemoveViewProp_14(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BDB RID: 39899 RVA: 0x000DCB14 File Offset: 0x000DAD14
		public virtual void RemoveViewProp(vtkProp prop)
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_RemoveViewProp_14(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009BDC RID: 39900
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointPlacer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BDD RID: 39901 RVA: 0x000DCB44 File Offset: 0x000DAD44
		public new static vtkPolyDataPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPointPlacer vtkPolyDataPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPointPlacer = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPointPlacer.Register(null);
				}
			}
			return vtkPolyDataPointPlacer;
		}

		// Token: 0x06009BDE RID: 39902
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_ValidateDisplayPosition_16(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		/// <summary>
		/// Given a display position, check the validity of this position.
		/// </summary>
		// Token: 0x06009BDF RID: 39903 RVA: 0x000DCBC4 File Offset: 0x000DADC4
		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateDisplayPosition_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		// Token: 0x06009BE0 RID: 39904
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_17(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Given a world position check the validity of this
		/// position according to the constraints of the placer
		/// </summary>
		// Token: 0x06009BE1 RID: 39905 RVA: 0x000DCBFC File Offset: 0x000DADFC
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateWorldPosition_17(base.GetCppThis(), worldPos);
		}

		// Token: 0x06009BE2 RID: 39906
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_18(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a world position and a world orientation,
		/// validate it according to the constraints of the placer.
		/// </summary>
		// Token: 0x06009BE3 RID: 39907 RVA: 0x000DCC1C File Offset: 0x000DAE1C
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateWorldPosition_18(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA1 RID: 3233
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA2 RID: 3234
		public new static readonly string MRClassNameKey = "class vtkPolyDataPointPlacer";
	}
}
