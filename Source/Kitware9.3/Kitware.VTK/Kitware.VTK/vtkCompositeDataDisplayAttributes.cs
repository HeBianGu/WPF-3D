using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataDisplayAttributes
	/// </summary>
	/// <remarks>
	///    Rendering attributes for a multi-block dataset.
	///
	/// The vtkCompositeDataDisplayAttributes class stores display attributes
	/// for individual blocks in a multi-block dataset. It uses the actual data
	/// block's pointer as a key (vtkDataObject*).
	///
	/// @warning It is considered unsafe to dereference key pointers at any time,
	/// they should only serve as keys to access the internal map.
	/// </remarks>
	// Token: 0x020007D4 RID: 2004
	public class vtkCompositeDataDisplayAttributes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014857 RID: 84055 RVA: 0x001D0B3F File Offset: 0x001CED3F
		static vtkCompositeDataDisplayAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataDisplayAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataDisplayAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014858 RID: 84056 RVA: 0x001D0B67 File Offset: 0x001CED67
		public vtkCompositeDataDisplayAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014859 RID: 84057
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601485A RID: 84058 RVA: 0x001D0B78 File Offset: 0x001CED78
		public new static vtkCompositeDataDisplayAttributes New()
		{
			vtkCompositeDataDisplayAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601485B RID: 84059 RVA: 0x001D0BCC File Offset: 0x001CEDCC
		public vtkCompositeDataDisplayAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601485C RID: 84060 RVA: 0x001D0C10 File Offset: 0x001CEE10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601485D RID: 84061
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_ComputeVisibleBounds_01(HandleRef cda, HandleRef dobj, IntPtr bounds);

		/// <summary>
		/// If the input \a dobj is a vtkCompositeDataSet, we will loop over the
		/// hierarchy recursively starting from initial index 0 and use only visible
		/// blocks, which is specified in the vtkCompositeDataDisplayAttributes \a cda,
		/// to compute the \a bounds.
		/// </summary>
		// Token: 0x0601485E RID: 84062 RVA: 0x001D0C1C File Offset: 0x001CEE1C
		public static void ComputeVisibleBounds(vtkCompositeDataDisplayAttributes cda, vtkDataObject dobj, IntPtr bounds)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_ComputeVisibleBounds_01((cda == null) ? default(HandleRef) : cda.GetCppThis(), (dobj == null) ? default(HandleRef) : dobj.GetCppThis(), bounds);
		}

		// Token: 0x0601485F RID: 84063
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_DataObjectFromIndex_02(uint flat_index, HandleRef parent_obj, uint current_flat_index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the DataObject corresponding to the node with index flat_index under
		/// parent_obj. Traverses the entire hierarchy recursively.
		/// </summary>
		// Token: 0x06014860 RID: 84064 RVA: 0x001D0C5C File Offset: 0x001CEE5C
		public static vtkDataObject DataObjectFromIndex(uint flat_index, vtkDataObject parent_obj, uint current_flat_index)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_DataObjectFromIndex_02(flat_index, (parent_obj == null) ? default(HandleRef) : parent_obj.GetCppThis(), current_flat_index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06014861 RID: 84065
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_GetBlockArrayAccessMode_03(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x06014862 RID: 84066 RVA: 0x001D0CE0 File Offset: 0x001CEEE0
		public int GetBlockArrayAccessMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockArrayAccessMode_03(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014863 RID: 84067
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_GetBlockArrayComponent_04(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x06014864 RID: 84068 RVA: 0x001D0D14 File Offset: 0x001CEF14
		public int GetBlockArrayComponent(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockArrayComponent_04(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014865 RID: 84069
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_GetBlockArrayId_05(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x06014866 RID: 84070 RVA: 0x001D0D48 File Offset: 0x001CEF48
		public int GetBlockArrayId(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockArrayId_05(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014867 RID: 84071
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCompositeDataDisplayAttributes_GetBlockArrayName_06(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x06014868 RID: 84072 RVA: 0x001D0D7C File Offset: 0x001CEF7C
		public string GetBlockArrayName(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockArrayName_06(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014869 RID: 84073
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_GetBlockColor_07(HandleRef pThis, HandleRef data_object, IntPtr color);

		/// <summary>
		/// Set/get the color for the block with \p data_object.
		/// </summary>
		// Token: 0x0601486A RID: 84074 RVA: 0x001D0DB0 File Offset: 0x001CEFB0
		public void GetBlockColor(vtkDataObject data_object, IntPtr color)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockColor_07(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), color);
		}

		// Token: 0x0601486B RID: 84075
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_GetBlockColor_08(HandleRef pThis, HandleRef data_object, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the color for the block with \p data_object.
		/// </summary>
		// Token: 0x0601486C RID: 84076 RVA: 0x001D0DE0 File Offset: 0x001CEFE0
		public vtkColor3d GetBlockColor(vtkDataObject data_object)
		{
			vtkColor3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockColor_08(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601486D RID: 84077
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_GetBlockColorMode_09(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x0601486E RID: 84078 RVA: 0x001D0E50 File Offset: 0x001CF050
		public int GetBlockColorMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockColorMode_09(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x0601486F RID: 84079
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataDisplayAttributes_GetBlockFieldDataTupleId_10(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x06014870 RID: 84080 RVA: 0x001D0E84 File Offset: 0x001CF084
		public long GetBlockFieldDataTupleId(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockFieldDataTupleId_10(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014871 RID: 84081
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockInterpolateScalarsBeforeMapping_11(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x06014872 RID: 84082 RVA: 0x001D0EB8 File Offset: 0x001CF0B8
		public bool GetBlockInterpolateScalarsBeforeMapping(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockInterpolateScalarsBeforeMapping_11(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014873 RID: 84083
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCompositeDataDisplayAttributes_GetBlockMaterial_12(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Set/get the material for the block with data_object.
		/// Only rendering backends that support advanced materials need to respect these.
		/// </summary>
		// Token: 0x06014874 RID: 84084 RVA: 0x001D0EF4 File Offset: 0x001CF0F4
		public string GetBlockMaterial(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockMaterial_12(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014875 RID: 84085
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompositeDataDisplayAttributes_GetBlockOpacity_13(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Set/get the opacity for the block with data_object.
		/// </summary>
		// Token: 0x06014876 RID: 84086 RVA: 0x001D0F28 File Offset: 0x001CF128
		public double GetBlockOpacity(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockOpacity_13(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014877 RID: 84087
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockPickability_14(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Set/get the pickability for the block with \p data_object.
		/// </summary>
		// Token: 0x06014878 RID: 84088 RVA: 0x001D0F5C File Offset: 0x001CF15C
		public bool GetBlockPickability(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockPickability_14(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014879 RID: 84089
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_GetBlockScalarMode_15(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x0601487A RID: 84090 RVA: 0x001D0F98 File Offset: 0x001CF198
		public int GetBlockScalarMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockScalarMode_15(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x0601487B RID: 84091
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_GetBlockScalarRange_16(HandleRef pThis, HandleRef data_object, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x0601487C RID: 84092 RVA: 0x001D0FCC File Offset: 0x001CF1CC
		public vtkVector2d GetBlockScalarRange(vtkDataObject data_object)
		{
			vtkVector2d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockScalarRange_16(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601487D RID: 84093
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockScalarVisibility_17(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x0601487E RID: 84094 RVA: 0x001D103C File Offset: 0x001CF23C
		public bool GetBlockScalarVisibility(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockScalarVisibility_17(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x0601487F RID: 84095
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockUseLookupTableScalarRange_18(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x06014880 RID: 84096 RVA: 0x001D1078 File Offset: 0x001CF278
		public bool GetBlockUseLookupTableScalarRange(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockUseLookupTableScalarRange_18(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014881 RID: 84097
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_GetBlockVisibility_19(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Set/get the visibility for the block with \p data_object.
		/// </summary>
		// Token: 0x06014882 RID: 84098 RVA: 0x001D10B4 File Offset: 0x001CF2B4
		public bool GetBlockVisibility(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetBlockVisibility_19(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014883 RID: 84099
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014884 RID: 84100 RVA: 0x001D10F0 File Offset: 0x001CF2F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06014885 RID: 84101
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014886 RID: 84102 RVA: 0x001D1110 File Offset: 0x001CF310
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06014887 RID: 84103
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayAccessMode_22(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x06014888 RID: 84104 RVA: 0x001D112C File Offset: 0x001CF32C
		public bool HasBlockArrayAccessMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayAccessMode_22(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014889 RID: 84105
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayAccessModes_23(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x0601488A RID: 84106 RVA: 0x001D1168 File Offset: 0x001CF368
		public bool HasBlockArrayAccessModes()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayAccessModes_23(base.GetCppThis()) != 0;
		}

		// Token: 0x0601488B RID: 84107
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayComponent_24(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x0601488C RID: 84108 RVA: 0x001D1190 File Offset: 0x001CF390
		public bool HasBlockArrayComponent(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayComponent_24(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x0601488D RID: 84109
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayComponents_25(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x0601488E RID: 84110 RVA: 0x001D11CC File Offset: 0x001CF3CC
		public bool HasBlockArrayComponents()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayComponents_25(base.GetCppThis()) != 0;
		}

		// Token: 0x0601488F RID: 84111
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayId_26(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x06014890 RID: 84112 RVA: 0x001D11F4 File Offset: 0x001CF3F4
		public bool HasBlockArrayId(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayId_26(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014891 RID: 84113
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayIds_27(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x06014892 RID: 84114 RVA: 0x001D1230 File Offset: 0x001CF430
		public bool HasBlockArrayIds()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayIds_27(base.GetCppThis()) != 0;
		}

		// Token: 0x06014893 RID: 84115
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayName_28(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x06014894 RID: 84116 RVA: 0x001D1258 File Offset: 0x001CF458
		public bool HasBlockArrayName(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayName_28(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014895 RID: 84117
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockArrayNames_29(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x06014896 RID: 84118 RVA: 0x001D1294 File Offset: 0x001CF494
		public bool HasBlockArrayNames()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockArrayNames_29(base.GetCppThis()) != 0;
		}

		// Token: 0x06014897 RID: 84119
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColor_30(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Returns true if the block with the given \p data_object has a color.
		/// </summary>
		// Token: 0x06014898 RID: 84120 RVA: 0x001D12BC File Offset: 0x001CF4BC
		public bool HasBlockColor(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockColor_30(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x06014899 RID: 84121
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColorMode_31(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x0601489A RID: 84122 RVA: 0x001D12F8 File Offset: 0x001CF4F8
		public bool HasBlockColorMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockColorMode_31(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x0601489B RID: 84123
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColorModes_32(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x0601489C RID: 84124 RVA: 0x001D1334 File Offset: 0x001CF534
		public bool HasBlockColorModes()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockColorModes_32(base.GetCppThis()) != 0;
		}

		// Token: 0x0601489D RID: 84125
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockColors_33(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block color is set.
		/// </summary>
		// Token: 0x0601489E RID: 84126 RVA: 0x001D135C File Offset: 0x001CF55C
		public bool HasBlockColors()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockColors_33(base.GetCppThis()) != 0;
		}

		// Token: 0x0601489F RID: 84127
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockFieldDataTupleId_34(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060148A0 RID: 84128 RVA: 0x001D1384 File Offset: 0x001CF584
		public bool HasBlockFieldDataTupleId(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockFieldDataTupleId_34(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148A1 RID: 84129
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockFieldDataTupleIds_35(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060148A2 RID: 84130 RVA: 0x001D13C0 File Offset: 0x001CF5C0
		public bool HasBlockFieldDataTupleIds()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockFieldDataTupleIds_35(base.GetCppThis()) != 0;
		}

		// Token: 0x060148A3 RID: 84131
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockInterpolateScalarsBeforeMapping_36(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x060148A4 RID: 84132 RVA: 0x001D13E8 File Offset: 0x001CF5E8
		public bool HasBlockInterpolateScalarsBeforeMapping(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockInterpolateScalarsBeforeMapping_36(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148A5 RID: 84133
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockInterpolateScalarsBeforeMappings_37(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x060148A6 RID: 84134 RVA: 0x001D1424 File Offset: 0x001CF624
		public bool HasBlockInterpolateScalarsBeforeMappings()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockInterpolateScalarsBeforeMappings_37(base.GetCppThis()) != 0;
		}

		// Token: 0x060148A7 RID: 84135
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockLookupTable_38(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetLookupTable
		/// </summary>
		// Token: 0x060148A8 RID: 84136 RVA: 0x001D144C File Offset: 0x001CF64C
		public bool HasBlockLookupTable(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockLookupTable_38(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148A9 RID: 84137
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockLookupTables_39(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetLookupTable
		/// </summary>
		// Token: 0x060148AA RID: 84138 RVA: 0x001D1488 File Offset: 0x001CF688
		public bool HasBlockLookupTables()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockLookupTables_39(base.GetCppThis()) != 0;
		}

		// Token: 0x060148AB RID: 84139
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockMaterial_40(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Returns true if the block with data_object has an material set.
		/// </summary>
		// Token: 0x060148AC RID: 84140 RVA: 0x001D14B0 File Offset: 0x001CF6B0
		public bool HasBlockMaterial(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockMaterial_40(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148AD RID: 84141
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockMaterials_41(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has an material set.
		/// </summary>
		// Token: 0x060148AE RID: 84142 RVA: 0x001D14EC File Offset: 0x001CF6EC
		public bool HasBlockMaterials()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockMaterials_41(base.GetCppThis()) != 0;
		}

		// Token: 0x060148AF RID: 84143
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockOpacities_42(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has an opacity set.
		/// </summary>
		// Token: 0x060148B0 RID: 84144 RVA: 0x001D1514 File Offset: 0x001CF714
		public bool HasBlockOpacities()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockOpacities_42(base.GetCppThis()) != 0;
		}

		// Token: 0x060148B1 RID: 84145
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockOpacity_43(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Returns true if the block with data_object has an opacity set.
		/// </summary>
		// Token: 0x060148B2 RID: 84146 RVA: 0x001D153C File Offset: 0x001CF73C
		public bool HasBlockOpacity(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockOpacity_43(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148B3 RID: 84147
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockPickabilities_44(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block pickability is set.
		/// </summary>
		// Token: 0x060148B4 RID: 84148 RVA: 0x001D1578 File Offset: 0x001CF778
		public bool HasBlockPickabilities()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockPickabilities_44(base.GetCppThis()) != 0;
		}

		// Token: 0x060148B5 RID: 84149
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockPickability_45(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Returns true if the block with the given data_object has a pickability
		/// set.
		/// </summary>
		// Token: 0x060148B6 RID: 84150 RVA: 0x001D15A0 File Offset: 0x001CF7A0
		public bool HasBlockPickability(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockPickability_45(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148B7 RID: 84151
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarMode_46(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x060148B8 RID: 84152 RVA: 0x001D15DC File Offset: 0x001CF7DC
		public bool HasBlockScalarMode(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarMode_46(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148B9 RID: 84153
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarModes_47(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x060148BA RID: 84154 RVA: 0x001D1618 File Offset: 0x001CF818
		public bool HasBlockScalarModes()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarModes_47(base.GetCppThis()) != 0;
		}

		// Token: 0x060148BB RID: 84155
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarRange_48(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x060148BC RID: 84156 RVA: 0x001D1640 File Offset: 0x001CF840
		public bool HasBlockScalarRange(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarRange_48(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148BD RID: 84157
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarRanges_49(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x060148BE RID: 84158 RVA: 0x001D167C File Offset: 0x001CF87C
		public bool HasBlockScalarRanges()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarRanges_49(base.GetCppThis()) != 0;
		}

		// Token: 0x060148BF RID: 84159
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarVisibilities_50(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x060148C0 RID: 84160 RVA: 0x001D16A4 File Offset: 0x001CF8A4
		public bool HasBlockScalarVisibilities()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarVisibilities_50(base.GetCppThis()) != 0;
		}

		// Token: 0x060148C1 RID: 84161
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockScalarVisibility_51(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x060148C2 RID: 84162 RVA: 0x001D16CC File Offset: 0x001CF8CC
		public bool HasBlockScalarVisibility(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockScalarVisibility_51(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148C3 RID: 84163
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockUseLookupTableScalarRange_52(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x060148C4 RID: 84164 RVA: 0x001D1708 File Offset: 0x001CF908
		public bool HasBlockUseLookupTableScalarRange(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockUseLookupTableScalarRange_52(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148C5 RID: 84165
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockUseLookupTableScalarRanges_53(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x060148C6 RID: 84166 RVA: 0x001D1744 File Offset: 0x001CF944
		public bool HasBlockUseLookupTableScalarRanges()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockUseLookupTableScalarRanges_53(base.GetCppThis()) != 0;
		}

		// Token: 0x060148C7 RID: 84167
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockVisibilities_54(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block visibility is set.
		/// </summary>
		// Token: 0x060148C8 RID: 84168 RVA: 0x001D176C File Offset: 0x001CF96C
		public bool HasBlockVisibilities()
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockVisibilities_54(base.GetCppThis()) != 0;
		}

		// Token: 0x060148C9 RID: 84169
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributes_HasBlockVisibility_55(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Returns true if the block with the given data_object has a visibility
		/// set.
		/// </summary>
		// Token: 0x060148CA RID: 84170 RVA: 0x001D1794 File Offset: 0x001CF994
		public bool HasBlockVisibility(vtkDataObject data_object)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_HasBlockVisibility_55(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis()) != 0;
		}

		// Token: 0x060148CB RID: 84171
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_IsA_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060148CC RID: 84172 RVA: 0x001D17D0 File Offset: 0x001CF9D0
		public override int IsA(string type)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_IsA_56(base.GetCppThis(), type);
		}

		// Token: 0x060148CD RID: 84173
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributes_IsTypeOf_57([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060148CE RID: 84174 RVA: 0x001D17F0 File Offset: 0x001CF9F0
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_IsTypeOf_57(type);
		}

		// Token: 0x060148CF RID: 84175
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060148D0 RID: 84176 RVA: 0x001D180C File Offset: 0x001CFA0C
		public new vtkCompositeDataDisplayAttributes NewInstance()
		{
			vtkCompositeDataDisplayAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_NewInstance_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060148D1 RID: 84177
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayAccessMode_60(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x060148D2 RID: 84178 RVA: 0x001D1868 File Offset: 0x001CFA68
		public void RemoveBlockArrayAccessMode(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayAccessMode_60(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148D3 RID: 84179
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayAccessModes_61(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x060148D4 RID: 84180 RVA: 0x001D1897 File Offset: 0x001CFA97
		public void RemoveBlockArrayAccessModes()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayAccessModes_61(base.GetCppThis());
		}

		// Token: 0x060148D5 RID: 84181
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayComponent_62(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x060148D6 RID: 84182 RVA: 0x001D18A8 File Offset: 0x001CFAA8
		public void RemoveBlockArrayComponent(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayComponent_62(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148D7 RID: 84183
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayComponents_63(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x060148D8 RID: 84184 RVA: 0x001D18D7 File Offset: 0x001CFAD7
		public void RemoveBlockArrayComponents()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayComponents_63(base.GetCppThis());
		}

		// Token: 0x060148D9 RID: 84185
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayId_64(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x060148DA RID: 84186 RVA: 0x001D18E8 File Offset: 0x001CFAE8
		public void RemoveBlockArrayId(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayId_64(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148DB RID: 84187
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayIds_65(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x060148DC RID: 84188 RVA: 0x001D1917 File Offset: 0x001CFB17
		public void RemoveBlockArrayIds()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayIds_65(base.GetCppThis());
		}

		// Token: 0x060148DD RID: 84189
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayName_66(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x060148DE RID: 84190 RVA: 0x001D1928 File Offset: 0x001CFB28
		public void RemoveBlockArrayName(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayName_66(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148DF RID: 84191
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockArrayNames_67(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x060148E0 RID: 84192 RVA: 0x001D1957 File Offset: 0x001CFB57
		public void RemoveBlockArrayNames()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockArrayNames_67(base.GetCppThis());
		}

		// Token: 0x060148E1 RID: 84193
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColor_68(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Removes the block color for the block with \p data_object.
		/// </summary>
		// Token: 0x060148E2 RID: 84194 RVA: 0x001D1968 File Offset: 0x001CFB68
		public void RemoveBlockColor(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockColor_68(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148E3 RID: 84195
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColorMode_69(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x060148E4 RID: 84196 RVA: 0x001D1998 File Offset: 0x001CFB98
		public void RemoveBlockColorMode(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockColorMode_69(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148E5 RID: 84197
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColorModes_70(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x060148E6 RID: 84198 RVA: 0x001D19C7 File Offset: 0x001CFBC7
		public void RemoveBlockColorModes()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockColorModes_70(base.GetCppThis());
		}

		// Token: 0x060148E7 RID: 84199
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockColors_71(HandleRef pThis);

		/// <summary>
		/// Removes all block colors.
		/// </summary>
		// Token: 0x060148E8 RID: 84200 RVA: 0x001D19D6 File Offset: 0x001CFBD6
		public void RemoveBlockColors()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockColors_71(base.GetCppThis());
		}

		// Token: 0x060148E9 RID: 84201
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockFieldDataTupleId_72(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060148EA RID: 84202 RVA: 0x001D19E8 File Offset: 0x001CFBE8
		public void RemoveBlockFieldDataTupleId(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockFieldDataTupleId_72(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148EB RID: 84203
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockFieldDataTupleIds_73(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x060148EC RID: 84204 RVA: 0x001D1A17 File Offset: 0x001CFC17
		public void RemoveBlockFieldDataTupleIds()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockFieldDataTupleIds_73(base.GetCppThis());
		}

		// Token: 0x060148ED RID: 84205
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockInterpolateScalarsBeforeMapping_74(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x060148EE RID: 84206 RVA: 0x001D1A28 File Offset: 0x001CFC28
		public void RemoveBlockInterpolateScalarsBeforeMapping(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockInterpolateScalarsBeforeMapping_74(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148EF RID: 84207
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockInterpolateScalarsBeforeMappings_75(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x060148F0 RID: 84208 RVA: 0x001D1A57 File Offset: 0x001CFC57
		public void RemoveBlockInterpolateScalarsBeforeMappings()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockInterpolateScalarsBeforeMappings_75(base.GetCppThis());
		}

		// Token: 0x060148F1 RID: 84209
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockLookupTable_76(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetLookupTable
		/// </summary>
		// Token: 0x060148F2 RID: 84210 RVA: 0x001D1A68 File Offset: 0x001CFC68
		public void RemoveBlockLookupTable(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockLookupTable_76(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148F3 RID: 84211
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockLookupTables_77(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetLookupTable
		/// </summary>
		// Token: 0x060148F4 RID: 84212 RVA: 0x001D1A97 File Offset: 0x001CFC97
		public void RemoveBlockLookupTables()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockLookupTables_77(base.GetCppThis());
		}

		// Token: 0x060148F5 RID: 84213
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockMaterial_78(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Removes the set material for the block with data_object.
		/// </summary>
		// Token: 0x060148F6 RID: 84214 RVA: 0x001D1AA8 File Offset: 0x001CFCA8
		public void RemoveBlockMaterial(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockMaterial_78(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148F7 RID: 84215
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockMaterials_79(HandleRef pThis);

		/// <summary>
		/// Removes all block materialss.
		/// </summary>
		// Token: 0x060148F8 RID: 84216 RVA: 0x001D1AD7 File Offset: 0x001CFCD7
		public void RemoveBlockMaterials()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockMaterials_79(base.GetCppThis());
		}

		// Token: 0x060148F9 RID: 84217
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockOpacities_80(HandleRef pThis);

		/// <summary>
		/// Removes all block opacities.
		/// </summary>
		// Token: 0x060148FA RID: 84218 RVA: 0x001D1AE6 File Offset: 0x001CFCE6
		public void RemoveBlockOpacities()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockOpacities_80(base.GetCppThis());
		}

		// Token: 0x060148FB RID: 84219
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockOpacity_81(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Removes the set opacity for the block with data_object.
		/// </summary>
		// Token: 0x060148FC RID: 84220 RVA: 0x001D1AF8 File Offset: 0x001CFCF8
		public void RemoveBlockOpacity(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockOpacity_81(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x060148FD RID: 84221
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockPickabilities_82(HandleRef pThis);

		/// <summary>
		/// Removes all block pickability flags. This effectively sets the pickability
		/// for all blocks to true.
		/// </summary>
		// Token: 0x060148FE RID: 84222 RVA: 0x001D1B27 File Offset: 0x001CFD27
		public void RemoveBlockPickabilities()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockPickabilities_82(base.GetCppThis());
		}

		// Token: 0x060148FF RID: 84223
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockPickability_83(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Removes the block pickability flag for the block with data_object.
		/// </summary>
		// Token: 0x06014900 RID: 84224 RVA: 0x001D1B38 File Offset: 0x001CFD38
		public void RemoveBlockPickability(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockPickability_83(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014901 RID: 84225
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarMode_84(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x06014902 RID: 84226 RVA: 0x001D1B68 File Offset: 0x001CFD68
		public void RemoveBlockScalarMode(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarMode_84(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014903 RID: 84227
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarModes_85(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x06014904 RID: 84228 RVA: 0x001D1B97 File Offset: 0x001CFD97
		public void RemoveBlockScalarModes()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarModes_85(base.GetCppThis());
		}

		// Token: 0x06014905 RID: 84229
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarRange_86(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x06014906 RID: 84230 RVA: 0x001D1BA8 File Offset: 0x001CFDA8
		public void RemoveBlockScalarRange(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarRange_86(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014907 RID: 84231
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarRanges_87(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x06014908 RID: 84232 RVA: 0x001D1BD7 File Offset: 0x001CFDD7
		public void RemoveBlockScalarRanges()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarRanges_87(base.GetCppThis());
		}

		// Token: 0x06014909 RID: 84233
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarVisibilities_88(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x0601490A RID: 84234 RVA: 0x001D1BE6 File Offset: 0x001CFDE6
		public void RemoveBlockScalarVisibilities()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarVisibilities_88(base.GetCppThis());
		}

		// Token: 0x0601490B RID: 84235
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockScalarVisibility_89(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x0601490C RID: 84236 RVA: 0x001D1BF8 File Offset: 0x001CFDF8
		public void RemoveBlockScalarVisibility(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockScalarVisibility_89(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x0601490D RID: 84237
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockUseLookupTableScalarRange_90(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x0601490E RID: 84238 RVA: 0x001D1C28 File Offset: 0x001CFE28
		public void RemoveBlockUseLookupTableScalarRange(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockUseLookupTableScalarRange_90(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x0601490F RID: 84239
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockUseLookupTableScalarRanges_91(HandleRef pThis);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x06014910 RID: 84240 RVA: 0x001D1C57 File Offset: 0x001CFE57
		public void RemoveBlockUseLookupTableScalarRanges()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockUseLookupTableScalarRanges_91(base.GetCppThis());
		}

		// Token: 0x06014911 RID: 84241
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockVisibilities_92(HandleRef pThis);

		/// <summary>
		/// Removes all block visibility flags. This effectively sets the visibility
		/// for all blocks to true.
		/// </summary>
		// Token: 0x06014912 RID: 84242 RVA: 0x001D1C66 File Offset: 0x001CFE66
		public void RemoveBlockVisibilities()
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockVisibilities_92(base.GetCppThis());
		}

		// Token: 0x06014913 RID: 84243
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_RemoveBlockVisibility_93(HandleRef pThis, HandleRef data_object);

		/// <summary>
		/// Removes the block visibility flag for the block with data_object.
		/// </summary>
		// Token: 0x06014914 RID: 84244 RVA: 0x001D1C78 File Offset: 0x001CFE78
		public void RemoveBlockVisibility(vtkDataObject data_object)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_RemoveBlockVisibility_93(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis());
		}

		// Token: 0x06014915 RID: 84245
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributes_SafeDownCast_94(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014916 RID: 84246 RVA: 0x001D1CA8 File Offset: 0x001CFEA8
		public new static vtkCompositeDataDisplayAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SafeDownCast_94((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataDisplayAttributes = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataDisplayAttributes.Register(null);
				}
			}
			return vtkCompositeDataDisplayAttributes;
		}

		// Token: 0x06014917 RID: 84247
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockArrayAccessMode_95(HandleRef pThis, HandleRef data_object, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayAccessMode
		/// </summary>
		// Token: 0x06014918 RID: 84248 RVA: 0x001D1D28 File Offset: 0x001CFF28
		public void SetBlockArrayAccessMode(vtkDataObject data_object, int value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockArrayAccessMode_95(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x06014919 RID: 84249
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockArrayComponent_96(HandleRef pThis, HandleRef data_object, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayComponent
		/// </summary>
		// Token: 0x0601491A RID: 84250 RVA: 0x001D1D58 File Offset: 0x001CFF58
		public void SetBlockArrayComponent(vtkDataObject data_object, int value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockArrayComponent_96(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x0601491B RID: 84251
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockArrayId_97(HandleRef pThis, HandleRef data_object, int value);

		/// <summary>
		/// @see vtkMapper::SetArrayId
		/// </summary>
		// Token: 0x0601491C RID: 84252 RVA: 0x001D1D88 File Offset: 0x001CFF88
		public void SetBlockArrayId(vtkDataObject data_object, int value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockArrayId_97(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x0601491D RID: 84253
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockArrayName_98(HandleRef pThis, HandleRef data_object, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// @see vtkMapper::SetArrayName
		/// </summary>
		// Token: 0x0601491E RID: 84254 RVA: 0x001D1DB8 File Offset: 0x001CFFB8
		public void SetBlockArrayName(vtkDataObject data_object, string value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockArrayName_98(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x0601491F RID: 84255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockColor_99(HandleRef pThis, HandleRef data_object, IntPtr color);

		/// <summary>
		/// Set/get the color for the block with \p data_object.
		/// </summary>
		// Token: 0x06014920 RID: 84256 RVA: 0x001D1DE8 File Offset: 0x001CFFE8
		public void SetBlockColor(vtkDataObject data_object, IntPtr color)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockColor_99(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), color);
		}

		// Token: 0x06014921 RID: 84257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockColorMode_100(HandleRef pThis, HandleRef data_object, int value);

		/// <summary>
		/// @see vtkMapper::SetColorMode
		/// </summary>
		// Token: 0x06014922 RID: 84258 RVA: 0x001D1E18 File Offset: 0x001D0018
		public void SetBlockColorMode(vtkDataObject data_object, int value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockColorMode_100(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x06014923 RID: 84259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockFieldDataTupleId_101(HandleRef pThis, HandleRef data_object, long value);

		/// <summary>
		/// @see vtkMapper::SetFieldDataTupleId
		/// </summary>
		// Token: 0x06014924 RID: 84260 RVA: 0x001D1E48 File Offset: 0x001D0048
		public void SetBlockFieldDataTupleId(vtkDataObject data_object, long value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockFieldDataTupleId_101(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x06014925 RID: 84261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockInterpolateScalarsBeforeMapping_102(HandleRef pThis, HandleRef data_object, byte value);

		/// <summary>
		/// @see vtkMapper::SetInterpolateScalarsBeforeMapping
		/// </summary>
		// Token: 0x06014926 RID: 84262 RVA: 0x001D1E78 File Offset: 0x001D0078
		public void SetBlockInterpolateScalarsBeforeMapping(vtkDataObject data_object, bool value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockInterpolateScalarsBeforeMapping_102(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06014927 RID: 84263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockMaterial_103(HandleRef pThis, HandleRef data_object, [MarshalAs(UnmanagedType.LPUTF8Str)] string material);

		/// <summary>
		/// Set/get the material for the block with data_object.
		/// Only rendering backends that support advanced materials need to respect these.
		/// </summary>
		// Token: 0x06014928 RID: 84264 RVA: 0x001D1EB0 File Offset: 0x001D00B0
		public void SetBlockMaterial(vtkDataObject data_object, string material)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockMaterial_103(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), material);
		}

		// Token: 0x06014929 RID: 84265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockOpacity_104(HandleRef pThis, HandleRef data_object, double opacity);

		/// <summary>
		/// Set/get the opacity for the block with data_object.
		/// </summary>
		// Token: 0x0601492A RID: 84266 RVA: 0x001D1EE0 File Offset: 0x001D00E0
		public void SetBlockOpacity(vtkDataObject data_object, double opacity)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockOpacity_104(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), opacity);
		}

		// Token: 0x0601492B RID: 84267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockPickability_105(HandleRef pThis, HandleRef data_object, byte visible);

		/// <summary>
		/// Set/get the pickability for the block with \p data_object.
		/// </summary>
		// Token: 0x0601492C RID: 84268 RVA: 0x001D1F10 File Offset: 0x001D0110
		public void SetBlockPickability(vtkDataObject data_object, bool visible)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockPickability_105(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		// Token: 0x0601492D RID: 84269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockScalarMode_106(HandleRef pThis, HandleRef data_object, int value);

		/// <summary>
		/// @see vtkMapper::SetScalarMode
		/// </summary>
		// Token: 0x0601492E RID: 84270 RVA: 0x001D1F48 File Offset: 0x001D0148
		public void SetBlockScalarMode(vtkDataObject data_object, int value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockScalarMode_106(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value);
		}

		// Token: 0x0601492F RID: 84271
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockScalarRange_107(HandleRef pThis, HandleRef data_object, HandleRef value);

		/// <summary>
		/// @see vtkMapper::SetScalarRange
		/// </summary>
		// Token: 0x06014930 RID: 84272 RVA: 0x001D1F78 File Offset: 0x001D0178
		public void SetBlockScalarRange(vtkDataObject data_object, vtkVector2d value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockScalarRange_107(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x06014931 RID: 84273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockScalarVisibility_108(HandleRef pThis, HandleRef data_object, byte value);

		/// <summary>
		/// @see vtkMapper::SetScalarVisibility
		/// </summary>
		// Token: 0x06014932 RID: 84274 RVA: 0x001D1FBC File Offset: 0x001D01BC
		public void SetBlockScalarVisibility(vtkDataObject data_object, bool value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockScalarVisibility_108(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06014933 RID: 84275
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockUseLookupTableScalarRange_109(HandleRef pThis, HandleRef data_object, byte value);

		/// <summary>
		/// @see vtkMapper::SetUseLookupTableScalarRange
		/// </summary>
		// Token: 0x06014934 RID: 84276 RVA: 0x001D1FF4 File Offset: 0x001D01F4
		public void SetBlockUseLookupTableScalarRange(vtkDataObject data_object, bool value)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockUseLookupTableScalarRange_109(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06014935 RID: 84277
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributes_SetBlockVisibility_110(HandleRef pThis, HandleRef data_object, byte visible);

		/// <summary>
		/// Set/get the visibility for the block with \p data_object.
		/// </summary>
		// Token: 0x06014936 RID: 84278 RVA: 0x001D202C File Offset: 0x001D022C
		public void SetBlockVisibility(vtkDataObject data_object, bool visible)
		{
			vtkCompositeDataDisplayAttributes.vtkCompositeDataDisplayAttributes_SetBlockVisibility_110(base.GetCppThis(), (data_object == null) ? default(HandleRef) : data_object.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CE RID: 6094
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataDisplayAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017CF RID: 6095
		public new static readonly string MRClassNameKey = "class vtkCompositeDataDisplayAttributes";
	}
}
