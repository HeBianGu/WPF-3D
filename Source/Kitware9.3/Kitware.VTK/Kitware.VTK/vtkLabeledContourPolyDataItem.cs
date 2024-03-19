using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabeledContourPolyDataItem
	/// </summary>
	/// <remarks>
	///    Filter that translate a vtkPolyData 2D mesh into vtkContextItems.
	///
	/// @warning
	/// The input vtkPolyData should be a 2D mesh.
	///
	/// </remarks>
	// Token: 0x020007B4 RID: 1972
	public class vtkLabeledContourPolyDataItem : vtkPolyDataItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601440B RID: 82955 RVA: 0x001C9F9C File Offset: 0x001C819C
		static vtkLabeledContourPolyDataItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledContourPolyDataItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledContourPolyDataItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601440C RID: 82956 RVA: 0x001C9FC4 File Offset: 0x001C81C4
		public vtkLabeledContourPolyDataItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601440D RID: 82957
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourPolyDataItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601440E RID: 82958 RVA: 0x001C9FD4 File Offset: 0x001C81D4
		public new static vtkLabeledContourPolyDataItem New()
		{
			vtkLabeledContourPolyDataItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601440F RID: 82959 RVA: 0x001CA028 File Offset: 0x001C8228
		public vtkLabeledContourPolyDataItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014410 RID: 82960 RVA: 0x001CA06C File Offset: 0x001C826C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014411 RID: 82961
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabeledContourPolyDataItem_GetLabelVisibility_01(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x06014412 RID: 82962 RVA: 0x001CA078 File Offset: 0x001C8278
		public virtual bool GetLabelVisibility()
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetLabelVisibility_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06014413 RID: 82963
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014414 RID: 82964 RVA: 0x001CA0A0 File Offset: 0x001C82A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014415 RID: 82965
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014416 RID: 82966 RVA: 0x001CA0C0 File Offset: 0x001C82C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06014417 RID: 82967
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabeledContourPolyDataItem_GetSkipDistance_04(HandleRef pThis);

		/// <summary>
		/// Ensure that there are at least SkipDistance pixels between labels. This
		/// is only enforced on labels along the same line. The default is 0.
		/// </summary>
		// Token: 0x06014418 RID: 82968 RVA: 0x001CA0DC File Offset: 0x001C82DC
		public virtual double GetSkipDistance()
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetSkipDistance_04(base.GetCppThis());
		}

		// Token: 0x06014419 RID: 82969
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourPolyDataItem_GetTextProperties_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text properties used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		///
		/// If the TextPropertyMapping array exists, then it is used to identify which
		/// text property to use for each label as follows: If the scalar value of a
		/// line is found in the mapping, the index of the value in mapping is used to
		/// lookup the text property in the collection. If there are more mapping
		/// values than properties, the properties are looped through until the
		/// mapping is exhausted.
		///
		/// Lines with scalar values missing from the mapping are assigned text
		/// properties in a round-robin fashion starting from the beginning of the
		/// collection, repeating from the start of the collection as necessary.
		/// @sa SetTextProperty
		/// @sa SetTextPropertyMapping
		/// </summary>
		// Token: 0x0601441A RID: 82970 RVA: 0x001CA0FC File Offset: 0x001C82FC
		public virtual vtkTextPropertyCollection GetTextProperties()
		{
			vtkTextPropertyCollection vtkTextPropertyCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetTextProperties_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextPropertyCollection = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextPropertyCollection.Register(null);
				}
			}
			return vtkTextPropertyCollection;
		}

		// Token: 0x0601441B RID: 82971
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourPolyDataItem_GetTextPropertyMapping_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Values in this array correspond to vtkTextProperty objects in the
		/// TextProperties collection. If a contour line's scalar value exists in
		/// this array, the corresponding text property is used for the label.
		/// See SetTextProperties for more information.
		/// </summary>
		// Token: 0x0601441C RID: 82972 RVA: 0x001CA16C File Offset: 0x001C836C
		public virtual vtkDoubleArray GetTextPropertyMapping()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_GetTextPropertyMapping_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601441D RID: 82973
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledContourPolyDataItem_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601441E RID: 82974 RVA: 0x001CA1DC File Offset: 0x001C83DC
		public override int IsA(string type)
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601441F RID: 82975
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledContourPolyDataItem_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014420 RID: 82976 RVA: 0x001CA1FC File Offset: 0x001C83FC
		public new static int IsTypeOf(string type)
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_IsTypeOf_08(type);
		}

		// Token: 0x06014421 RID: 82977
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_LabelVisibilityOff_09(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x06014422 RID: 82978 RVA: 0x001CA216 File Offset: 0x001C8416
		public virtual void LabelVisibilityOff()
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_LabelVisibilityOff_09(base.GetCppThis());
		}

		// Token: 0x06014423 RID: 82979
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_LabelVisibilityOn_10(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x06014424 RID: 82980 RVA: 0x001CA225 File Offset: 0x001C8425
		public virtual void LabelVisibilityOn()
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_LabelVisibilityOn_10(base.GetCppThis());
		}

		// Token: 0x06014425 RID: 82981
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourPolyDataItem_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014426 RID: 82982 RVA: 0x001CA234 File Offset: 0x001C8434
		public new vtkLabeledContourPolyDataItem NewInstance()
		{
			vtkLabeledContourPolyDataItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014427 RID: 82983
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabeledContourPolyDataItem_Paint_13(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x06014428 RID: 82984 RVA: 0x001CA290 File Offset: 0x001C8490
		public override bool Paint(vtkContext2D painter)
		{
			return vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_Paint_13(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06014429 RID: 82985
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourPolyDataItem_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601442A RID: 82986 RVA: 0x001CA2CC File Offset: 0x001C84CC
		public new static vtkLabeledContourPolyDataItem SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledContourPolyDataItem vtkLabeledContourPolyDataItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledContourPolyDataItem = (vtkLabeledContourPolyDataItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledContourPolyDataItem.Register(null);
				}
			}
			return vtkLabeledContourPolyDataItem;
		}

		// Token: 0x0601442B RID: 82987
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_SetLabelVisibility_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x0601442C RID: 82988 RVA: 0x001CA34B File Offset: 0x001C854B
		public virtual void SetLabelVisibility(bool _arg)
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SetLabelVisibility_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601442D RID: 82989
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_SetSkipDistance_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Ensure that there are at least SkipDistance pixels between labels. This
		/// is only enforced on labels along the same line. The default is 0.
		/// </summary>
		// Token: 0x0601442E RID: 82990 RVA: 0x001CA363 File Offset: 0x001C8563
		public virtual void SetSkipDistance(double _arg)
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SetSkipDistance_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601442F RID: 82991
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_SetTextProperties_17(HandleRef pThis, HandleRef coll);

		/// <summary>
		/// The text properties used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		///
		/// If the TextPropertyMapping array exists, then it is used to identify which
		/// text property to use for each label as follows: If the scalar value of a
		/// line is found in the mapping, the index of the value in mapping is used to
		/// lookup the text property in the collection. If there are more mapping
		/// values than properties, the properties are looped through until the
		/// mapping is exhausted.
		///
		/// Lines with scalar values missing from the mapping are assigned text
		/// properties in a round-robin fashion starting from the beginning of the
		/// collection, repeating from the start of the collection as necessary.
		/// @sa SetTextProperty
		/// @sa SetTextPropertyMapping
		/// </summary>
		// Token: 0x06014430 RID: 82992 RVA: 0x001CA374 File Offset: 0x001C8574
		public virtual void SetTextProperties(vtkTextPropertyCollection coll)
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SetTextProperties_17(base.GetCppThis(), (coll == null) ? default(HandleRef) : coll.GetCppThis());
		}

		// Token: 0x06014431 RID: 82993
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_SetTextProperty_18(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The text property used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		/// @note This is a convenience method that clears TextProperties and inserts
		/// the argument as the only property in the collection.
		/// @sa SetTextProperties
		/// </summary>
		// Token: 0x06014432 RID: 82994 RVA: 0x001CA3A4 File Offset: 0x001C85A4
		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SetTextProperty_18(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06014433 RID: 82995
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourPolyDataItem_SetTextPropertyMapping_19(HandleRef pThis, HandleRef mapping);

		/// <summary>
		/// Values in this array correspond to vtkTextProperty objects in the
		/// TextProperties collection. If a contour line's scalar value exists in
		/// this array, the corresponding text property is used for the label.
		/// See SetTextProperties for more information.
		/// </summary>
		// Token: 0x06014434 RID: 82996 RVA: 0x001CA3D4 File Offset: 0x001C85D4
		public virtual void SetTextPropertyMapping(vtkDoubleArray mapping)
		{
			vtkLabeledContourPolyDataItem.vtkLabeledContourPolyDataItem_SetTextPropertyMapping_19(base.GetCppThis(), (mapping == null) ? default(HandleRef) : mapping.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001777 RID: 6007
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledContourPolyDataItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001778 RID: 6008
		public new static readonly string MRClassNameKey = "class vtkLabeledContourPolyDataItem";
	}
}
