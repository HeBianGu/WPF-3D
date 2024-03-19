using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Contour interpolator for polygonal data
	///
	///
	/// vtkPolyDataContourLineInterpolator is an abstract base class for contour
	/// line interpolators that interpolate on polygonal data.
	///
	/// </remarks>
	// Token: 0x02000356 RID: 854
	public abstract class vtkPolyDataContourLineInterpolator : vtkContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009BA7 RID: 39847 RVA: 0x000DC54D File Offset: 0x000DA74D
		static vtkPolyDataContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009BA8 RID: 39848 RVA: 0x000DC575 File Offset: 0x000DA775
		public vtkPolyDataContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009BA9 RID: 39849 RVA: 0x000DC583 File Offset: 0x000DA783
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009BAA RID: 39850
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BAB RID: 39851 RVA: 0x000DC590 File Offset: 0x000DA790
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06009BAC RID: 39852
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BAD RID: 39853 RVA: 0x000DC5B0 File Offset: 0x000DA7B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06009BAE RID: 39854
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_GetPolys_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Be sure to add polydata on which you wish to place points to this list
		/// or they will not be considered for placement.
		/// </summary>
		// Token: 0x06009BAF RID: 39855 RVA: 0x000DC5CC File Offset: 0x000DA7CC
		public virtual vtkPolyDataCollection GetPolys()
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_GetPolys_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}

		// Token: 0x06009BB0 RID: 39856
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataContourLineInterpolator_InterpolateLine_04(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Subclasses that wish to interpolate a line segment must implement this.
		/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
		/// and idx2, that allow the contour to adhere to a bezier curve.
		/// </summary>
		// Token: 0x06009BB1 RID: 39857 RVA: 0x000DC63C File Offset: 0x000DA83C
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_InterpolateLine_04(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06009BB2 RID: 39858
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataContourLineInterpolator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BB3 RID: 39859 RVA: 0x000DC688 File Offset: 0x000DA888
		public override int IsA(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06009BB4 RID: 39860
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataContourLineInterpolator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BB5 RID: 39861 RVA: 0x000DC6A8 File Offset: 0x000DA8A8
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_IsTypeOf_06(type);
		}

		// Token: 0x06009BB6 RID: 39862
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BB7 RID: 39863 RVA: 0x000DC6C4 File Offset: 0x000DA8C4
		public new vtkPolyDataContourLineInterpolator NewInstance()
		{
			vtkPolyDataContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009BB8 RID: 39864
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BB9 RID: 39865 RVA: 0x000DC720 File Offset: 0x000DA920
		public new static vtkPolyDataContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataContourLineInterpolator vtkPolyDataContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataContourLineInterpolator = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataContourLineInterpolator.Register(null);
				}
			}
			return vtkPolyDataContourLineInterpolator;
		}

		// Token: 0x06009BBA RID: 39866
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataContourLineInterpolator_UpdateNode_09(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		/// <summary>
		/// The interpolator is given a chance to update the node.
		/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
		/// so it automatically sticks to edges in the vicinity as the user
		/// constructs the contour.
		/// Returns 0 if the node (world position) is unchanged.
		/// </summary>
		// Token: 0x06009BBB RID: 39867 RVA: 0x000DC7A0 File Offset: 0x000DA9A0
		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_UpdateNode_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C9F RID: 3231
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA0 RID: 3232
		public new static readonly string MRClassNameKey = "class vtkPolyDataContourLineInterpolator";
	}
}
