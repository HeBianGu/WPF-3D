using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBiDimensionalRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkBiDimensionalWidget
	///
	/// The vtkBiDimensionalRepresentation is used to represent the
	/// bi-dimensional measure of an object. This representation
	/// consists of two perpendicular lines defined by four
	/// vtkHandleRepresentations. The four handles can be independently
	/// manipulated consistent with the orthogonal constraint on the lines. (Note:
	/// the four points are referred to as Point1, Point2, Point3 and
	/// Point4. Point1 and Point2 define the first line; and Point3 and Point4
	/// define the second orthogonal line.) This particular class is an abstract
	/// class, concrete subclasses (e.g., vtkBiDimensionalRepresentation2D) actual
	/// implement the widget.
	///
	/// To create this widget, you click to place the first two points. The third
	/// point is mirrored with the fourth point; when you place the third point
	/// (which is orthogonal to the lined defined by the first two points), the
	/// fourth point is dropped as well. After definition, the four points can be
	/// moved (in constrained fashion, preserving orthogonality). Further, the
	/// entire widget can be translated by grabbing the center point of the widget;
	/// each line can be moved along the other line; and the entire widget can be
	/// rotated around its center point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAngleWidget vtkHandleRepresentation vtkBiDimensionalRepresentation2D
	/// </seealso>
	// Token: 0x020002C7 RID: 711
	public abstract class vtkBiDimensionalRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600800A RID: 32778 RVA: 0x000B7D17 File Offset: 0x000B5F17
		static vtkBiDimensionalRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600800B RID: 32779 RVA: 0x000B7D3F File Offset: 0x000B5F3F
		public vtkBiDimensionalRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600800C RID: 32780 RVA: 0x000B7D4D File Offset: 0x000B5F4D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600800D RID: 32781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalRepresentation_GetID_01(HandleRef pThis);

		/// <summary>
		/// Set/get the id to display in the label.
		/// </summary>
		// Token: 0x0600800E RID: 32782 RVA: 0x000B7D58 File Offset: 0x000B5F58
		public virtual long GetID()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetID_01(base.GetCppThis());
		}

		// Token: 0x0600800F RID: 32783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelFormat_02(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the distance value.
		/// </summary>
		// Token: 0x06008010 RID: 32784 RVA: 0x000B7D78 File Offset: 0x000B5F78
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelFormat_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008011 RID: 32785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelPosition_03(HandleRef pThis);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06008012 RID: 32786 RVA: 0x000B7DB4 File Offset: 0x000B5FB4
		public virtual IntPtr GetLabelPosition()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelPosition_03(base.GetCppThis());
		}

		// Token: 0x06008013 RID: 32787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06008014 RID: 32788 RVA: 0x000B7DD3 File Offset: 0x000B5FD3
		public virtual void GetLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelPosition_04(base.GetCppThis(), pos);
		}

		// Token: 0x06008015 RID: 32789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelText_05(HandleRef pThis);

		/// <summary>
		/// Get the text shown in the widget's label.
		/// </summary>
		// Token: 0x06008016 RID: 32790 RVA: 0x000B7DE4 File Offset: 0x000B5FE4
		public virtual string GetLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelText_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008017 RID: 32791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBiDimensionalRepresentation_GetLength1_06(HandleRef pThis);

		/// <summary>
		/// Return the length of the line defined by (Point1,Point2). This is the
		/// distance in the world coordinate system.
		/// </summary>
		// Token: 0x06008018 RID: 32792 RVA: 0x000B7E20 File Offset: 0x000B6020
		public virtual double GetLength1()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLength1_06(base.GetCppThis());
		}

		// Token: 0x06008019 RID: 32793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBiDimensionalRepresentation_GetLength2_07(HandleRef pThis);

		/// <summary>
		/// Return the length of the line defined by (Point3,Point4). This is the
		/// distance in the world coordinate system.
		/// </summary>
		// Token: 0x0600801A RID: 32794 RVA: 0x000B7E40 File Offset: 0x000B6040
		public virtual double GetLength2()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLength2_07(base.GetCppThis());
		}

		// Token: 0x0600801B RID: 32795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetLine1Visibility_08(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x0600801C RID: 32796 RVA: 0x000B7E60 File Offset: 0x000B6060
		public virtual int GetLine1Visibility()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLine1Visibility_08(base.GetCppThis());
		}

		// Token: 0x0600801D RID: 32797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetLine2Visibility_09(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x0600801E RID: 32798 RVA: 0x000B7E80 File Offset: 0x000B6080
		public virtual int GetLine2Visibility()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLine2Visibility_09(base.GetCppThis());
		}

		// Token: 0x0600801F RID: 32799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008020 RID: 32800 RVA: 0x000B7EA0 File Offset: 0x000B60A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06008021 RID: 32801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008022 RID: 32802 RVA: 0x000B7EC0 File Offset: 0x000B60C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06008023 RID: 32803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008024 RID: 32804 RVA: 0x000B7EDA File Offset: 0x000B60DA
		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_12(base.GetCppThis(), pos);
		}

		// Token: 0x06008025 RID: 32805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint1Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used within the
		/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
		/// grabbing these representations and setting the properties
		/// appropriately.)
		/// </summary>
		// Token: 0x06008026 RID: 32806 RVA: 0x000B7EEC File Offset: 0x000B60EC
		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1Representation_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008027 RID: 32807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint1WorldPosition_14(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008028 RID: 32808 RVA: 0x000B7F5B File Offset: 0x000B615B
		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1WorldPosition_14(base.GetCppThis(), pos);
		}

		// Token: 0x06008029 RID: 32809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_15(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600802A RID: 32810 RVA: 0x000B7F6B File Offset: 0x000B616B
		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_15(base.GetCppThis(), pos);
		}

		// Token: 0x0600802B RID: 32811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint2Representation_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used within the
		/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
		/// grabbing these representations and setting the properties
		/// appropriately.)
		/// </summary>
		// Token: 0x0600802C RID: 32812 RVA: 0x000B7F7C File Offset: 0x000B617C
		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2Representation_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600802D RID: 32813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint2WorldPosition_17(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600802E RID: 32814 RVA: 0x000B7FEB File Offset: 0x000B61EB
		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2WorldPosition_17(base.GetCppThis(), pos);
		}

		// Token: 0x0600802F RID: 32815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_18(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008030 RID: 32816 RVA: 0x000B7FFB File Offset: 0x000B61FB
		public virtual void GetPoint3DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_18(base.GetCppThis(), pos);
		}

		// Token: 0x06008031 RID: 32817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint3Representation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used within the
		/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
		/// grabbing these representations and setting the properties
		/// appropriately.)
		/// </summary>
		// Token: 0x06008032 RID: 32818 RVA: 0x000B800C File Offset: 0x000B620C
		public virtual vtkHandleRepresentation GetPoint3Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3Representation_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008033 RID: 32819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint3WorldPosition_20(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008034 RID: 32820 RVA: 0x000B807B File Offset: 0x000B627B
		public virtual void GetPoint3WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3WorldPosition_20(base.GetCppThis(), pos);
		}

		// Token: 0x06008035 RID: 32821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_21(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008036 RID: 32822 RVA: 0x000B808B File Offset: 0x000B628B
		public virtual void GetPoint4DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_21(base.GetCppThis(), pos);
		}

		// Token: 0x06008037 RID: 32823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint4Representation_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle representations used within the
		/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
		/// grabbing these representations and setting the properties
		/// appropriately.)
		/// </summary>
		// Token: 0x06008038 RID: 32824 RVA: 0x000B809C File Offset: 0x000B629C
		public virtual vtkHandleRepresentation GetPoint4Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4Representation_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008039 RID: 32825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint4WorldPosition_23(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600803A RID: 32826 RVA: 0x000B810B File Offset: 0x000B630B
		public virtual void GetPoint4WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4WorldPosition_23(base.GetCppThis(), pos);
		}

		// Token: 0x0600803B RID: 32827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_24(HandleRef pThis);

		/// <summary>
		/// Toggle whether to display the label above or below the widget.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x0600803C RID: 32828 RVA: 0x000B811C File Offset: 0x000B631C
		public virtual int GetShowLabelAboveWidget()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_24(base.GetCppThis());
		}

		// Token: 0x0600803D RID: 32829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetTolerance_25(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x0600803E RID: 32830 RVA: 0x000B813C File Offset: 0x000B633C
		public virtual int GetTolerance()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetTolerance_25(base.GetCppThis());
		}

		// Token: 0x0600803F RID: 32831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetToleranceMaxValue_26(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06008040 RID: 32832 RVA: 0x000B815C File Offset: 0x000B635C
		public virtual int GetToleranceMaxValue()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetToleranceMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06008041 RID: 32833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_GetToleranceMinValue_27(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06008042 RID: 32834 RVA: 0x000B817C File Offset: 0x000B637C
		public virtual int GetToleranceMinValue()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetToleranceMinValue_27(base.GetCppThis());
		}

		// Token: 0x06008043 RID: 32835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_GetWorldLabelPosition_28(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the widget's label in display coordinates.
		/// </summary>
		// Token: 0x06008044 RID: 32836 RVA: 0x000B819B File Offset: 0x000B639B
		public virtual void GetWorldLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetWorldLabelPosition_28(base.GetCppThis(), pos);
		}

		// Token: 0x06008045 RID: 32837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_29(HandleRef pThis);

		/// <summary>
		/// This method is used to specify the type of handle representation to use
		/// for the four internal vtkHandleRepresentations within
		/// vtkBiDimensionalRepresentation.  To use this method, create a dummy
		/// vtkHandleRepresentation (or subclass), and then invoke this method with
		/// this dummy. Then the vtkBiDimensionalRepresentation uses this dummy to
		/// clone four vtkHandleRepresentations of the same type. Make sure you set the
		/// handle representation before the widget is enabled. (The method
		/// InstantiateHandleRepresentation() is invoked by the vtkBiDimensionalWidget
		/// for the purposes of cloning.)
		/// </summary>
		// Token: 0x06008046 RID: 32838 RVA: 0x000B81AB File Offset: 0x000B63AB
		public virtual void InstantiateHandleRepresentation()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_29(base.GetCppThis());
		}

		// Token: 0x06008047 RID: 32839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008048 RID: 32840 RVA: 0x000B81BC File Offset: 0x000B63BC
		public override int IsA(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x06008049 RID: 32841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBiDimensionalRepresentation_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600804A RID: 32842 RVA: 0x000B81DC File Offset: 0x000B63DC
		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_IsTypeOf_31(type);
		}

		// Token: 0x0600804B RID: 32843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOff_32(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x0600804C RID: 32844 RVA: 0x000B81F6 File Offset: 0x000B63F6
		public virtual void Line1VisibilityOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line1VisibilityOff_32(base.GetCppThis());
		}

		// Token: 0x0600804D RID: 32845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOn_33(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x0600804E RID: 32846 RVA: 0x000B8205 File Offset: 0x000B6405
		public virtual void Line1VisibilityOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line1VisibilityOn_33(base.GetCppThis());
		}

		// Token: 0x0600804F RID: 32847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOff_34(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x06008050 RID: 32848 RVA: 0x000B8214 File Offset: 0x000B6414
		public virtual void Line2VisibilityOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line2VisibilityOff_34(base.GetCppThis());
		}

		// Token: 0x06008051 RID: 32849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOn_35(HandleRef pThis);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x06008052 RID: 32850 RVA: 0x000B8223 File Offset: 0x000B6423
		public virtual void Line2VisibilityOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line2VisibilityOn_35(base.GetCppThis());
		}

		// Token: 0x06008053 RID: 32851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008054 RID: 32852 RVA: 0x000B8234 File Offset: 0x000B6434
		public new vtkBiDimensionalRepresentation NewInstance()
		{
			vtkBiDimensionalRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008055 RID: 32853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Point2WidgetInteraction_37(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008056 RID: 32854 RVA: 0x000B828E File Offset: 0x000B648E
		public virtual void Point2WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Point2WidgetInteraction_37(base.GetCppThis(), e);
		}

		// Token: 0x06008057 RID: 32855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_Point3WidgetInteraction_38(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008058 RID: 32856 RVA: 0x000B829E File Offset: 0x000B649E
		public virtual void Point3WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Point3WidgetInteraction_38(base.GetCppThis(), e);
		}

		// Token: 0x06008059 RID: 32857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBiDimensionalRepresentation_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600805A RID: 32858 RVA: 0x000B82B0 File Offset: 0x000B64B0
		public new static vtkBiDimensionalRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation;
		}

		// Token: 0x0600805B RID: 32859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetHandleRepresentation_40(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// This method is used to specify the type of handle representation to use
		/// for the four internal vtkHandleRepresentations within
		/// vtkBiDimensionalRepresentation.  To use this method, create a dummy
		/// vtkHandleRepresentation (or subclass), and then invoke this method with
		/// this dummy. Then the vtkBiDimensionalRepresentation uses this dummy to
		/// clone four vtkHandleRepresentations of the same type. Make sure you set the
		/// handle representation before the widget is enabled. (The method
		/// InstantiateHandleRepresentation() is invoked by the vtkBiDimensionalWidget
		/// for the purposes of cloning.)
		/// </summary>
		// Token: 0x0600805C RID: 32860 RVA: 0x000B8330 File Offset: 0x000B6530
		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetHandleRepresentation_40(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x0600805D RID: 32861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetID_41(HandleRef pThis, long id);

		/// <summary>
		/// Set/get the id to display in the label.
		/// </summary>
		// Token: 0x0600805E RID: 32862 RVA: 0x000B835F File Offset: 0x000B655F
		public void SetID(long id)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetID_41(base.GetCppThis(), id);
		}

		// Token: 0x0600805F RID: 32863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetLabelFormat_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the distance value.
		/// </summary>
		// Token: 0x06008060 RID: 32864 RVA: 0x000B836F File Offset: 0x000B656F
		public virtual void SetLabelFormat(string _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLabelFormat_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06008061 RID: 32865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetLine1Visibility_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x06008062 RID: 32866 RVA: 0x000B837F File Offset: 0x000B657F
		public virtual void SetLine1Visibility(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLine1Visibility_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06008063 RID: 32867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetLine2Visibility_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Special methods for turning off the lines that define the bi-dimensional
		/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
		/// control the appearance of the widget. Note: turning off Line1 actually turns
		/// off Line1 and Line2.
		/// </summary>
		// Token: 0x06008064 RID: 32868 RVA: 0x000B838F File Offset: 0x000B658F
		public virtual void SetLine2Visibility(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLine2Visibility_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06008065 RID: 32869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_45(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008066 RID: 32870 RVA: 0x000B839F File Offset: 0x000B659F
		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_45(base.GetCppThis(), pos);
		}

		// Token: 0x06008067 RID: 32871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint1WorldPosition_46(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008068 RID: 32872 RVA: 0x000B83AF File Offset: 0x000B65AF
		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint1WorldPosition_46(base.GetCppThis(), pos);
		}

		// Token: 0x06008069 RID: 32873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_47(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600806A RID: 32874 RVA: 0x000B83BF File Offset: 0x000B65BF
		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_47(base.GetCppThis(), pos);
		}

		// Token: 0x0600806B RID: 32875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint2WorldPosition_48(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600806C RID: 32876 RVA: 0x000B83CF File Offset: 0x000B65CF
		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint2WorldPosition_48(base.GetCppThis(), pos);
		}

		// Token: 0x0600806D RID: 32877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_49(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600806E RID: 32878 RVA: 0x000B83DF File Offset: 0x000B65DF
		public virtual void SetPoint3DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_49(base.GetCppThis(), pos);
		}

		// Token: 0x0600806F RID: 32879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint3WorldPosition_50(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008070 RID: 32880 RVA: 0x000B83EF File Offset: 0x000B65EF
		public virtual void SetPoint3WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint3WorldPosition_50(base.GetCppThis(), pos);
		}

		// Token: 0x06008071 RID: 32881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_51(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008072 RID: 32882 RVA: 0x000B83FF File Offset: 0x000B65FF
		public virtual void SetPoint4DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_51(base.GetCppThis(), pos);
		}

		// Token: 0x06008073 RID: 32883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint4WorldPosition_52(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the four points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008074 RID: 32884 RVA: 0x000B840F File Offset: 0x000B660F
		public virtual void SetPoint4WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint4WorldPosition_52(base.GetCppThis(), pos);
		}

		// Token: 0x06008075 RID: 32885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Toggle whether to display the label above or below the widget.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x06008076 RID: 32886 RVA: 0x000B841F File Offset: 0x000B661F
		public virtual void SetShowLabelAboveWidget(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06008077 RID: 32887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_SetTolerance_54(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the representation (in
		/// pixels) in which the cursor is considered near enough to the
		/// representation to be active.
		/// </summary>
		// Token: 0x06008078 RID: 32888 RVA: 0x000B842F File Offset: 0x000B662F
		public virtual void SetTolerance(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetTolerance_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06008079 RID: 32889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_55(HandleRef pThis);

		/// <summary>
		/// Toggle whether to display the label above or below the widget.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x0600807A RID: 32890 RVA: 0x000B843F File Offset: 0x000B663F
		public virtual void ShowLabelAboveWidgetOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_55(base.GetCppThis());
		}

		// Token: 0x0600807B RID: 32891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_56(HandleRef pThis);

		/// <summary>
		/// Toggle whether to display the label above or below the widget.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x0600807C RID: 32892 RVA: 0x000B844E File Offset: 0x000B664E
		public virtual void ShowLabelAboveWidgetOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_56(base.GetCppThis());
		}

		// Token: 0x0600807D RID: 32893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_StartWidgetDefinition_57(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600807E RID: 32894 RVA: 0x000B845D File Offset: 0x000B665D
		public virtual void StartWidgetDefinition(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_StartWidgetDefinition_57(base.GetCppThis(), e);
		}

		// Token: 0x0600807F RID: 32895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBiDimensionalRepresentation_StartWidgetManipulation_58(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008080 RID: 32896 RVA: 0x000B846D File Offset: 0x000B666D
		public virtual void StartWidgetManipulation(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_StartWidgetManipulation_58(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AD0 RID: 2768
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AD1 RID: 2769
		public new static readonly string MRClassNameKey = "class vtkBiDimensionalRepresentation";

		/// <summary>
		/// Specify the format to use for labelling the distance. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the distance value.
		/// </summary>
		// Token: 0x020002C8 RID: 712
		public enum NearP1_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AD3 RID: 2771
			NearP1 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AD4 RID: 2772
			NearP2,
			/// <summary>enum member</summary>
			// Token: 0x04000AD5 RID: 2773
			NearP3,
			/// <summary>enum member</summary>
			// Token: 0x04000AD6 RID: 2774
			NearP4,
			/// <summary>enum member</summary>
			// Token: 0x04000AD7 RID: 2775
			OnCenter = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000AD8 RID: 2776
			OnL1Inner = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000AD9 RID: 2777
			OnL1Outer,
			/// <summary>enum member</summary>
			// Token: 0x04000ADA RID: 2778
			OnL2Inner,
			/// <summary>enum member</summary>
			// Token: 0x04000ADB RID: 2779
			OnL2Outer,
			/// <summary>enum member</summary>
			// Token: 0x04000ADC RID: 2780
			Outside = 0
		}
	}
}
