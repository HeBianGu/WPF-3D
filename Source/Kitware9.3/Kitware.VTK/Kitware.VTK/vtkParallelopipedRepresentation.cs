using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelopipedRepresentation
	/// </summary>
	/// <remarks>
	///    Default representation for vtkParallelopipedWidget
	///
	/// This class provides the default geometrical representation for
	/// vtkParallelopipedWidget. As a result of interactions of the widget, this
	/// representation can take on of the following shapes:
	/// &lt;p&gt;1) A parallelopiped. (8 handles, 6 faces)
	/// &lt;p&gt;2) Paralleopiped with a chair depression on any one handle. (A chair
	/// is a depression on one of the handles that carves inwards so as to allow
	/// the user to visualize cuts in the volume). (14 handles, 9 faces).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelopipedWidget
	/// </seealso>
	// Token: 0x02000349 RID: 841
	public class vtkParallelopipedRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060098D9 RID: 39129 RVA: 0x000D89DF File Offset: 0x000D6BDF
		static vtkParallelopipedRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelopipedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060098DA RID: 39130 RVA: 0x000D8A07 File Offset: 0x000D6C07
		public vtkParallelopipedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060098DB RID: 39131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060098DC RID: 39132 RVA: 0x000D8A18 File Offset: 0x000D6C18
		public new static vtkParallelopipedRepresentation New()
		{
			vtkParallelopipedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060098DD RID: 39133 RVA: 0x000D8A6C File Offset: 0x000D6C6C
		public vtkParallelopipedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060098DE RID: 39134 RVA: 0x000D8AB0 File Offset: 0x000D6CB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060098DF RID: 39135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// This actually constructs the geometry of the widget from the various
		/// data parameters.
		/// </summary>
		// Token: 0x060098E0 RID: 39136 RVA: 0x000D8ABB File Offset: 0x000D6CBB
		public override void BuildRepresentation()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060098E1 RID: 39137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Given and x-y display coordinate, compute the interaction state of
		/// the widget.
		/// </summary>
		// Token: 0x060098E2 RID: 39138 RVA: 0x000D8ACC File Offset: 0x000D6CCC
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060098E3 RID: 39139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_GetActors_03(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods to satisfy the superclass.
		/// </summary>
		// Token: 0x060098E4 RID: 39140 RVA: 0x000D8AF0 File Offset: 0x000D6CF0
		public override void GetActors(vtkPropCollection pc)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetActors_03(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x060098E5 RID: 39141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_GetBoundingPlanes_04(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Get the bounding planes of the object. The first 6 planes will
		/// be bounding planes of the parallelopiped. If in chair mode, three
		/// additional planes will be present. The last three planes will be those
		/// of the chair. The normals of all the planes will point into the object.
		/// </summary>
		// Token: 0x060098E6 RID: 39142 RVA: 0x000D8B20 File Offset: 0x000D6D20
		public void GetBoundingPlanes(vtkPlaneCollection pc)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetBoundingPlanes_04(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x060098E7 RID: 39143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// The parallelopiped polydata.
		/// </summary>
		// Token: 0x060098E8 RID: 39144 RVA: 0x000D8B50 File Offset: 0x000D6D50
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060098E9 RID: 39145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetFaceProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties. When a face is being translated, the face gets
		/// highlighted with the SelectedFaceProperty.
		/// </summary>
		// Token: 0x060098EA RID: 39146 RVA: 0x000D8B98 File Offset: 0x000D6D98
		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetFaceProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098EB RID: 39147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x060098EC RID: 39148 RVA: 0x000D8C08 File Offset: 0x000D6E08
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHandleProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098ED RID: 39149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleRepresentation_08(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x060098EE RID: 39150 RVA: 0x000D8C78 File Offset: 0x000D6E78
		public vtkHandleRepresentation GetHandleRepresentation(int index)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHandleRepresentation_08(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		// Token: 0x060098EF RID: 39151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x060098F0 RID: 39152 RVA: 0x000D8CE8 File Offset: 0x000D6EE8
		public virtual vtkProperty GetHoveredHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098F1 RID: 39153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkParallelopipedRepresentation_GetMinimumThickness_10(HandleRef pThis);

		/// <summary>
		/// Minimum thickness for the parallelopiped. User interactions cannot make
		/// any individual axis of the parallopiped thinner than this value.
		/// Default is 0.05 expressed as a fraction of the diagonal of the bounding
		/// box used in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x060098F2 RID: 39154 RVA: 0x000D8D58 File Offset: 0x000D6F58
		public virtual double GetMinimumThickness()
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetMinimumThickness_10(base.GetCppThis());
		}

		// Token: 0x060098F3 RID: 39155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098F4 RID: 39156 RVA: 0x000D8D78 File Offset: 0x000D6F78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060098F5 RID: 39157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098F6 RID: 39158 RVA: 0x000D8D98 File Offset: 0x000D6F98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060098F7 RID: 39159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetOutlineProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties. These are the properties with which the
		/// parallelopiped wireframe is rendered.
		/// </summary>
		// Token: 0x060098F8 RID: 39160 RVA: 0x000D8DB4 File Offset: 0x000D6FB4
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetOutlineProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098F9 RID: 39161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_GetPolyData_14(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// The parallelopiped polydata.
		/// </summary>
		// Token: 0x060098FA RID: 39162 RVA: 0x000D8E24 File Offset: 0x000D7024
		public void GetPolyData(vtkPolyData pd)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetPolyData_14(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x060098FB RID: 39163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedFaceProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the face properties. When a face is being translated, the face gets
		/// highlighted with the SelectedFaceProperty.
		/// </summary>
		// Token: 0x060098FC RID: 39164 RVA: 0x000D8E54 File Offset: 0x000D7054
		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedFaceProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098FD RID: 39165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedHandleProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x060098FE RID: 39166 RVA: 0x000D8EC4 File Offset: 0x000D70C4
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedHandleProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x060098FF RID: 39167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedOutlineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the outline properties. These are the properties with which the
		/// parallelopiped wireframe is rendered.
		/// </summary>
		// Token: 0x06009900 RID: 39168 RVA: 0x000D8F34 File Offset: 0x000D7134
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedOutlineProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009901 RID: 39169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_HandlesOff_18(HandleRef pThis);

		/// <summary>
		/// Turns the visibility of the handles on/off. Sometimes they may get in
		/// the way of visualization.
		/// </summary>
		// Token: 0x06009902 RID: 39170 RVA: 0x000D8FA3 File Offset: 0x000D71A3
		public void HandlesOff()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_HandlesOff_18(base.GetCppThis());
		}

		// Token: 0x06009903 RID: 39171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_HandlesOn_19(HandleRef pThis);

		/// <summary>
		/// Turns the visibility of the handles on/off. Sometimes they may get in
		/// the way of visualization.
		/// </summary>
		// Token: 0x06009904 RID: 39172 RVA: 0x000D8FB2 File Offset: 0x000D71B2
		public void HandlesOn()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_HandlesOn_19(base.GetCppThis());
		}

		// Token: 0x06009905 RID: 39173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedRepresentation_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009906 RID: 39174 RVA: 0x000D8FC4 File Offset: 0x000D71C4
		public override int IsA(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06009907 RID: 39175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedRepresentation_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009908 RID: 39176 RVA: 0x000D8FE4 File Offset: 0x000D71E4
		public new static int IsTypeOf(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_IsTypeOf_21(type);
		}

		// Token: 0x06009909 RID: 39177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600990A RID: 39178 RVA: 0x000D9000 File Offset: 0x000D7200
		public new vtkParallelopipedRepresentation NewInstance()
		{
			vtkParallelopipedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600990B RID: 39179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Place the widget in the scene. You can use either of the two APIs :
		/// 1) PlaceWidget( double bounds[6] )
		/// Creates a cuboid conforming to the said bounds.
		/// 2) PlaceWidget( double corners[8][3] )
		/// Creates a parallelopiped with corners specified. The order in
		/// which corners are specified must obey the following rule:
		/// Corner 0 - 1 - 2 - 3 - 0  forms a face
		/// Corner 4 - 5 - 6 - 7 - 4  forms a face
		/// Corner 0 - 4 - 5 - 1 - 0  forms a face
		/// Corner 1 - 5 - 6 - 2 - 1  forms a face
		/// Corner 2 - 6 - 7 - 3 - 2  forms a face
		/// Corner 3 - 7 - 4 - 0 - 3  forms a face
		/// </summary>
		// Token: 0x0600990C RID: 39180 RVA: 0x000D905A File Offset: 0x000D725A
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_PlaceWidget_24(base.GetCppThis(), bounds);
		}

		// Token: 0x0600990D RID: 39181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_PositionHandles_25(HandleRef pThis);

		/// <summary>
		/// Synchronize the parallelopiped handle positions with the
		/// Polygonal datastructure.
		/// </summary>
		// Token: 0x0600990E RID: 39182 RVA: 0x000D906A File Offset: 0x000D726A
		public virtual void PositionHandles()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_PositionHandles_25(base.GetCppThis());
		}

		// Token: 0x0600990F RID: 39183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009910 RID: 39184 RVA: 0x000D907C File Offset: 0x000D727C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_ReleaseGraphicsResources_26(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06009911 RID: 39185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedRepresentation_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009912 RID: 39186 RVA: 0x000D90AC File Offset: 0x000D72AC
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009913 RID: 39187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedRepresentation_RenderOverlay_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06009914 RID: 39188 RVA: 0x000D90E0 File Offset: 0x000D72E0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_RenderOverlay_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009915 RID: 39189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedRepresentation_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009916 RID: 39190 RVA: 0x000D9114 File Offset: 0x000D7314
		public new static vtkParallelopipedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelopipedRepresentation vtkParallelopipedRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedRepresentation = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedRepresentation.Register(null);
				}
			}
			return vtkParallelopipedRepresentation;
		}

		// Token: 0x06009917 RID: 39191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_Scale_30(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Given and x-y display coordinate, compute the interaction state of
		/// the widget.
		/// </summary>
		// Token: 0x06009918 RID: 39192 RVA: 0x000D9193 File Offset: 0x000D7393
		public virtual void Scale(int X, int Y)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Scale_30(base.GetCppThis(), X, Y);
		}

		// Token: 0x06009919 RID: 39193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetHandleProperty_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x0600991A RID: 39194 RVA: 0x000D91A4 File Offset: 0x000D73A4
		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHandleProperty_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600991B RID: 39195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetHandleRepresentation_32(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x0600991C RID: 39196 RVA: 0x000D91D4 File Offset: 0x000D73D4
		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHandleRepresentation_32(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x0600991D RID: 39197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetHoveredHandleProperty_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x0600991E RID: 39198 RVA: 0x000D9204 File Offset: 0x000D7404
		public virtual void SetHoveredHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHoveredHandleProperty_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600991F RID: 39199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetInteractionState_34(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., PointWidget)
		/// or other object. This controls how the interaction with the
		/// widget proceeds.
		/// </summary>
		// Token: 0x06009920 RID: 39200 RVA: 0x000D9233 File Offset: 0x000D7433
		public virtual void SetInteractionState(int _arg)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetInteractionState_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06009921 RID: 39201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetMinimumThickness_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Minimum thickness for the parallelopiped. User interactions cannot make
		/// any individual axis of the parallopiped thinner than this value.
		/// Default is 0.05 expressed as a fraction of the diagonal of the bounding
		/// box used in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009922 RID: 39202 RVA: 0x000D9243 File Offset: 0x000D7443
		public virtual void SetMinimumThickness(double _arg)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetMinimumThickness_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06009923 RID: 39203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_SetSelectedHandleProperty_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties.
		/// </summary>
		// Token: 0x06009924 RID: 39204 RVA: 0x000D9254 File Offset: 0x000D7454
		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetSelectedHandleProperty_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009925 RID: 39205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_Translate_37(HandleRef pThis, IntPtr translation);

		/// <summary>
		/// Given and x-y display coordinate, compute the interaction state of
		/// the widget.
		/// </summary>
		// Token: 0x06009926 RID: 39206 RVA: 0x000D9283 File Offset: 0x000D7483
		public virtual void Translate(IntPtr translation)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Translate_37(base.GetCppThis(), translation);
		}

		// Token: 0x06009927 RID: 39207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedRepresentation_Translate_38(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Given and x-y display coordinate, compute the interaction state of
		/// the widget.
		/// </summary>
		// Token: 0x06009928 RID: 39208 RVA: 0x000D9293 File Offset: 0x000D7493
		public virtual void Translate(int X, int Y)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Translate_38(base.GetCppThis(), X, Y);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C74 RID: 3188
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C75 RID: 3189
		public new static readonly string MRClassNameKey = "class vtkParallelopipedRepresentation";

		/// <summary>
		/// Given and x-y display coordinate, compute the interaction state of
		/// the widget.
		/// </summary>
		// Token: 0x0200034A RID: 842
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C77 RID: 3191
			ChairMode = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000C78 RID: 3192
			Inside = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C79 RID: 3193
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C7A RID: 3194
			RequestChairMode = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000C7B RID: 3195
			RequestResizeParallelopiped = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C7C RID: 3196
			RequestResizeParallelopipedAlongAnAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000C7D RID: 3197
			RequestRotateParallelopiped = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000C7E RID: 3198
			RequestScaleParallelopiped = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000C7F RID: 3199
			RequestTranslateParallelopiped = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000C80 RID: 3200
			ResizingParallelopiped = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000C81 RID: 3201
			ResizingParallelopipedAlongAnAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000C82 RID: 3202
			RotatingParallelopiped = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000C83 RID: 3203
			ScalingParallelopiped = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000C84 RID: 3204
			TranslatingParallelopiped = 11
		}
	}
}
