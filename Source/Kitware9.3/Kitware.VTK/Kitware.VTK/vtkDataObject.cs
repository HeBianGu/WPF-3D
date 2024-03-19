using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObject
	/// </summary>
	/// <remarks>
	///    general representation of visualization data
	///
	/// vtkDataObject is an general representation of visualization data. It serves
	/// to encapsulate instance variables and methods for visualization network
	/// execution, as well as representing data consisting of a field (i.e., just
	/// an unstructured pile of data). This is to be compared with a vtkDataSet,
	/// which is data with geometric and/or topological structure.
	///
	/// vtkDataObjects are used to represent arbitrary repositories of data via the
	/// vtkFieldData instance variable. These data must be eventually mapped into a
	/// concrete subclass of vtkDataSet before they can actually be displayed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSet vtkFieldData vtkDataObjectToDataSetFilter
	/// vtkFieldDataToAttributeDataFilter
	/// </seealso>
	// Token: 0x02000006 RID: 6
	public class vtkDataObject : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000196 RID: 406 RVA: 0x00008A24 File Offset: 0x00006C24
		static vtkDataObject()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObject"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000197 RID: 407 RVA: 0x00008A4C File Offset: 0x00006C4C
		public vtkDataObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000198 RID: 408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000199 RID: 409 RVA: 0x00008A5C File Offset: 0x00006C5C
		public new static vtkDataObject New()
		{
			vtkDataObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600019A RID: 410 RVA: 0x00008AB0 File Offset: 0x00006CB0
		public vtkDataObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObject.vtkDataObject_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600019B RID: 411 RVA: 0x00008AF4 File Offset: 0x00006CF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600019C RID: 412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_ALL_PIECES_EXTENT_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600019D RID: 413 RVA: 0x00008B00 File Offset: 0x00006D00
		public static vtkInformationIntegerVectorKey ALL_PIECES_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_ALL_PIECES_EXTENT_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x0600019E RID: 414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_BOUNDING_BOX_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600019F RID: 415 RVA: 0x00008B6C File Offset: 0x00006D6C
		public static vtkInformationDoubleVectorKey BOUNDING_BOX()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_BOUNDING_BOX_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x060001A0 RID: 416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_CELL_DATA_VECTOR_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001A1 RID: 417 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public static vtkInformationInformationVectorKey CELL_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_CELL_DATA_VECTOR_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x060001A2 RID: 418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_CopyInformationFromPipeline_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy from the pipeline information to the data object's own information.
		/// Called right before the main execution pass.
		/// </summary>
		// Token: 0x060001A3 RID: 419 RVA: 0x00008C44 File Offset: 0x00006E44
		public virtual void CopyInformationFromPipeline(vtkInformation arg0)
		{
			vtkDataObject.vtkDataObject_CopyInformationFromPipeline_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060001A4 RID: 420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_CopyInformationToPipeline_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy information from this data object to the pipeline information.
		/// This is used by the vtkTrivialProducer that is created when someone
		/// calls SetInputData() to connect a data object to a pipeline.
		/// </summary>
		// Token: 0x060001A5 RID: 421 RVA: 0x00008C74 File Offset: 0x00006E74
		public virtual void CopyInformationToPipeline(vtkInformation arg0)
		{
			vtkDataObject.vtkDataObject_CopyInformationToPipeline_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060001A6 RID: 422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_Crop_06(HandleRef pThis, IntPtr updateExtent);

		/// <summary>
		/// This method crops the data object (if necessary) so that the extent
		/// matches the update extent.
		/// </summary>
		// Token: 0x060001A7 RID: 423 RVA: 0x00008CA3 File Offset: 0x00006EA3
		public virtual void Crop(IntPtr updateExtent)
		{
			vtkDataObject.vtkDataObject_Crop_06(base.GetCppThis(), updateExtent);
		}

		// Token: 0x060001A8 RID: 424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_EXTENT_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001A9 RID: 425 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public static vtkInformationIntegerPointerKey DATA_EXTENT()
		{
			vtkInformationIntegerPointerKey vtkInformationIntegerPointerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_EXTENT_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerPointerKey = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerPointerKey.Register(null);
				}
			}
			return vtkInformationIntegerPointerKey;
		}

		// Token: 0x060001AA RID: 426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_EXTENT_TYPE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001AB RID: 427 RVA: 0x00008D20 File Offset: 0x00006F20
		public static vtkInformationIntegerKey DATA_EXTENT_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_EXTENT_TYPE_08(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001AC RID: 428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001AD RID: 429 RVA: 0x00008D8C File Offset: 0x00006F8C
		public static vtkInformationIntegerKey DATA_NUMBER_OF_GHOST_LEVELS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_09(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001AE RID: 430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_PIECES_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001AF RID: 431 RVA: 0x00008DF8 File Offset: 0x00006FF8
		public static vtkInformationIntegerKey DATA_NUMBER_OF_PIECES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_NUMBER_OF_PIECES_10(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001B0 RID: 432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_OBJECT_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001B1 RID: 433 RVA: 0x00008E64 File Offset: 0x00007064
		public static vtkInformationDataObjectKey DATA_OBJECT()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_OBJECT_11(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x060001B2 RID: 434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_PIECE_NUMBER_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001B3 RID: 435 RVA: 0x00008ED0 File Offset: 0x000070D0
		public static vtkInformationIntegerKey DATA_PIECE_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_PIECE_NUMBER_12(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001B4 RID: 436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_TIME_STEP_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001B5 RID: 437 RVA: 0x00008F3C File Offset: 0x0000713C
		public static vtkInformationDoubleKey DATA_TIME_STEP()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_TIME_STEP_13(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x060001B6 RID: 438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DATA_TYPE_NAME_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001B7 RID: 439 RVA: 0x00008FA8 File Offset: 0x000071A8
		public static vtkInformationStringKey DATA_TYPE_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_TYPE_NAME_14(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x060001B8 RID: 440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_DIRECTION_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001B9 RID: 441 RVA: 0x00009014 File Offset: 0x00007214
		public static vtkInformationDoubleVectorKey DIRECTION()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DIRECTION_15(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x060001BA RID: 442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_DataHasBeenGenerated_16(HandleRef pThis);

		/// <summary>
		/// This method is called by the source when it executes to generate data.
		/// It is sort of the opposite of ReleaseData.
		/// It sets the DataReleased flag to 0, and sets a new UpdateTime.
		/// </summary>
		// Token: 0x060001BB RID: 443 RVA: 0x0000907D File Offset: 0x0000727D
		public void DataHasBeenGenerated()
		{
			vtkDataObject.vtkDataObject_DataHasBeenGenerated_16(base.GetCppThis());
		}

		// Token: 0x060001BC RID: 444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_DeepCopy_17(HandleRef pThis, HandleRef src);

		/// <summary>
		/// The goal of the method is to copy the complete data from src into this object.
		/// The implementation is delegated to the differenent subclasses.
		/// If you want to copy the data up to the array pointers only, @see ShallowCopy.
		///
		/// This method deep copy the field data and copy the internal structure.
		/// </summary>
		// Token: 0x060001BD RID: 445 RVA: 0x0000908C File Offset: 0x0000728C
		public virtual void DeepCopy(vtkDataObject src)
		{
			vtkDataObject.vtkDataObject_DeepCopy_17(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x060001BE RID: 446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_EDGE_DATA_VECTOR_18(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001BF RID: 447 RVA: 0x000090BC File Offset: 0x000072BC
		public static vtkInformationInformationVectorKey EDGE_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_EDGE_DATA_VECTOR_18(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x060001C0 RID: 448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001C1 RID: 449 RVA: 0x00009128 File Offset: 0x00007328
		public static vtkInformationIntegerKey FIELD_ACTIVE_ATTRIBUTE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_19(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001C2 RID: 450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_ARRAY_TYPE_20(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001C3 RID: 451 RVA: 0x00009194 File Offset: 0x00007394
		public static vtkInformationIntegerKey FIELD_ARRAY_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ARRAY_TYPE_20(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001C4 RID: 452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_ASSOCIATION_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001C5 RID: 453 RVA: 0x00009200 File Offset: 0x00007400
		public static vtkInformationIntegerKey FIELD_ASSOCIATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ASSOCIATION_21(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001C6 RID: 454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_ATTRIBUTE_TYPE_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001C7 RID: 455 RVA: 0x0000926C File Offset: 0x0000746C
		public static vtkInformationIntegerKey FIELD_ATTRIBUTE_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ATTRIBUTE_TYPE_22(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001C8 RID: 456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_NAME_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001C9 RID: 457 RVA: 0x000092D8 File Offset: 0x000074D8
		public static vtkInformationStringKey FIELD_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NAME_23(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x060001CA RID: 458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001CB RID: 459 RVA: 0x00009344 File Offset: 0x00007544
		public static vtkInformationIntegerKey FIELD_NUMBER_OF_COMPONENTS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_24(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001CC RID: 460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_TUPLES_25(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001CD RID: 461 RVA: 0x000093B0 File Offset: 0x000075B0
		public static vtkInformationIntegerKey FIELD_NUMBER_OF_TUPLES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NUMBER_OF_TUPLES_25(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001CE RID: 462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_OPERATION_26(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001CF RID: 463 RVA: 0x0000941C File Offset: 0x0000761C
		public static vtkInformationIntegerKey FIELD_OPERATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_OPERATION_26(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x060001D0 RID: 464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_FIELD_RANGE_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001D1 RID: 465 RVA: 0x00009488 File Offset: 0x00007688
		public static vtkInformationDoubleVectorKey FIELD_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_RANGE_27(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x060001D2 RID: 466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetActiveFieldInformation_28(HandleRef info, int fieldAssociation, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the information object within the input information object's
		/// field data corresponding to the specified association
		/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS) and attribute
		/// (SCALARS, VECTORS, NORMALS, TCOORDS, or TENSORS)
		/// </summary>
		// Token: 0x060001D3 RID: 467 RVA: 0x000094F4 File Offset: 0x000076F4
		public static vtkInformation GetActiveFieldInformation(vtkInformation info, int fieldAssociation, int attributeType)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetActiveFieldInformation_28((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060001D4 RID: 468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataObject_GetActualMemorySize_29(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value).
		/// </summary>
		// Token: 0x060001D5 RID: 469 RVA: 0x00009578 File Offset: 0x00007778
		public virtual uint GetActualMemorySize()
		{
			return vtkDataObject.vtkDataObject_GetActualMemorySize_29(base.GetCppThis());
		}

		// Token: 0x060001D6 RID: 470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetAssociationTypeAsString_30(int associationType);

		/// <summary>
		/// Given an integer association type, this static method returns a string type
		/// for the attribute (i.e. associationType = 0: returns "Points").
		/// </summary>
		// Token: 0x060001D7 RID: 471 RVA: 0x00009598 File Offset: 0x00007798
		public static string GetAssociationTypeAsString(int associationType)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObject.vtkDataObject_GetAssociationTypeAsString_30(associationType));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060001D8 RID: 472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetAssociationTypeFromString_31([MarshalAs(UnmanagedType.LPUTF8Str)] string associationName);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x060001D9 RID: 473 RVA: 0x000095D0 File Offset: 0x000077D0
		public static int GetAssociationTypeFromString(string associationName)
		{
			return vtkDataObject.vtkDataObject_GetAssociationTypeFromString_31(associationName);
		}

		// Token: 0x060001DA RID: 474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetAttributeTypeForArray_32(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Retrieves the attribute type that an array came from.
		/// This is useful for obtaining which attribute type a input array
		/// to an algorithm came from (retrieved from GetInputAbstractArrayToProcesss).
		/// </summary>
		// Token: 0x060001DB RID: 475 RVA: 0x000095EC File Offset: 0x000077EC
		public virtual int GetAttributeTypeForArray(vtkAbstractArray arr)
		{
			return vtkDataObject.vtkDataObject_GetAttributeTypeForArray_32(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x060001DC RID: 476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetAttributes_33(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object of the specified
		/// attribute type. The type may be:
		/// &lt;ul&gt;
		/// &lt;li&gt;POINT  - Defined in vtkDataSet subclasses.
		/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
		/// &lt;li&gt;VERTEX - Defined in vtkGraph subclasses.
		/// &lt;li&gt;EDGE   - Defined in vtkGraph subclasses.
		/// &lt;li&gt;ROW    - Defined in vtkTable.
		/// &lt;/ul&gt;
		/// The other attribute type, FIELD, will return nullptr since
		/// field data is stored as a vtkFieldData instance, not a
		/// vtkDataSetAttributes instance. To retrieve field data, use
		/// GetAttributesAsFieldData.
		///
		/// @warning This method NEEDS to be
		/// overridden in subclasses to work as documented.
		/// If not, it returns nullptr for any type but FIELD.
		/// </summary>
		// Token: 0x060001DD RID: 477 RVA: 0x00009620 File Offset: 0x00007820
		public virtual vtkDataSetAttributes GetAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetAttributes_33(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x060001DE RID: 478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetAttributesAsFieldData_34(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object as a vtkFieldData.
		/// This returns non-null values in all the same cases as GetAttributes,
		/// in addition to the case of FIELD, which will return the field data
		/// for any vtkDataObject subclass.
		/// </summary>
		// Token: 0x060001DF RID: 479 RVA: 0x00009690 File Offset: 0x00007890
		public virtual vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetAttributesAsFieldData_34(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x060001E0 RID: 480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetData_35(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060001E1 RID: 481 RVA: 0x00009700 File Offset: 0x00007900
		public static vtkDataObject GetData(vtkInformation info)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetData_35((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060001E2 RID: 482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetData_36(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060001E3 RID: 483 RVA: 0x00009780 File Offset: 0x00007980
		public static vtkDataObject GetData(vtkInformationVector v, int i)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetData_36((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060001E4 RID: 484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetDataObjectType_37(HandleRef pThis);

		/// <summary>
		/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
		/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
		/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x060001E5 RID: 485 RVA: 0x00009800 File Offset: 0x00007A00
		public virtual int GetDataObjectType()
		{
			return vtkDataObject.vtkDataObject_GetDataObjectType_37(base.GetCppThis());
		}

		// Token: 0x060001E6 RID: 486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetDataReleased_38(HandleRef pThis);

		/// <summary>
		/// Get the flag indicating the data has been released.
		/// </summary>
		// Token: 0x060001E7 RID: 487 RVA: 0x00009820 File Offset: 0x00007A20
		public virtual int GetDataReleased()
		{
			return vtkDataObject.vtkDataObject_GetDataReleased_38(base.GetCppThis());
		}

		// Token: 0x060001E8 RID: 488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetExtentType_39(HandleRef pThis);

		/// <summary>
		/// The ExtentType will be left as VTK_PIECES_EXTENT for data objects
		/// such as vtkPolyData and vtkUnstructuredGrid. The ExtentType will be
		/// changed to VTK_3D_EXTENT for data objects with 3D structure such as
		/// vtkImageData (and its subclass vtkStructuredPoints), vtkRectilinearGrid,
		/// and vtkStructuredGrid. The default is the have an extent in pieces,
		/// with only one piece (no streaming possible).
		/// </summary>
		// Token: 0x060001E9 RID: 489 RVA: 0x00009840 File Offset: 0x00007A40
		public virtual int GetExtentType()
		{
			return vtkDataObject.vtkDataObject_GetExtentType_39(base.GetCppThis());
		}

		// Token: 0x060001EA RID: 490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetFieldData_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Assign or retrieve a general field data to this data object.
		/// </summary>
		// Token: 0x060001EB RID: 491 RVA: 0x00009860 File Offset: 0x00007A60
		public virtual vtkFieldData GetFieldData()
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetFieldData_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x060001EC RID: 492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetGhostArray_41(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghost arrays of the data object of the specified
		/// attribute type. The type may be:
		/// &lt;ul&gt;
		/// &lt;li&gt;POINT    - Defined in vtkDataSet subclasses
		/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
		/// &lt;/ul&gt;
		/// The other attribute types, will return nullptr since
		/// ghosts arrays are not defined for now outside of
		/// point or cell.
		/// </summary>
		// Token: 0x060001ED RID: 493 RVA: 0x000098D0 File Offset: 0x00007AD0
		public virtual vtkUnsignedCharArray GetGhostArray(int type)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetGhostArray_41(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060001EE RID: 494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_GetGlobalReleaseDataFlag_42();

		/// <summary>
		/// Turn on/off flag to control whether every object releases its data
		/// after being used by a filter.
		/// </summary>
		// Token: 0x060001EF RID: 495 RVA: 0x00009940 File Offset: 0x00007B40
		public static int GetGlobalReleaseDataFlag()
		{
			return vtkDataObject.vtkDataObject_GetGlobalReleaseDataFlag_42();
		}

		// Token: 0x060001F0 RID: 496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetInformation_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with this data object.
		/// </summary>
		// Token: 0x060001F1 RID: 497 RVA: 0x0000995C File Offset: 0x00007B5C
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetInformation_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060001F2 RID: 498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataObject_GetMTime_44(HandleRef pThis);

		/// <summary>
		/// Data objects are composite objects and need to check each part for MTime.
		/// The information object also needs to be considered.
		/// </summary>
		// Token: 0x060001F3 RID: 499 RVA: 0x000099CC File Offset: 0x00007BCC
		public override ulong GetMTime()
		{
			return vtkDataObject.vtkDataObject_GetMTime_44(base.GetCppThis());
		}

		// Token: 0x060001F4 RID: 500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_GetNamedFieldInformation_45(HandleRef info, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the information object within the input information object's
		/// field data corresponding to the specified association
		/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS) and name.
		/// </summary>
		// Token: 0x060001F5 RID: 501 RVA: 0x000099EC File Offset: 0x00007BEC
		public static vtkInformation GetNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetNamedFieldInformation_45((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060001F6 RID: 502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObject_GetNumberOfElements_46(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x060001F7 RID: 503 RVA: 0x00009A70 File Offset: 0x00007C70
		public virtual long GetNumberOfElements(int type)
		{
			return vtkDataObject.vtkDataObject_GetNumberOfElements_46(base.GetCppThis(), type);
		}

		// Token: 0x060001F8 RID: 504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObject_GetNumberOfGenerationsFromBase_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060001F9 RID: 505 RVA: 0x00009A90 File Offset: 0x00007C90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObject.vtkDataObject_GetNumberOfGenerationsFromBase_47(base.GetCppThis(), type);
		}

		// Token: 0x060001FA RID: 506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObject_GetNumberOfGenerationsFromBaseType_48([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060001FB RID: 507 RVA: 0x00009AB0 File Offset: 0x00007CB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObject.vtkDataObject_GetNumberOfGenerationsFromBaseType_48(type);
		}

		// Token: 0x060001FC RID: 508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataObject_GetUpdateTime_49(HandleRef pThis);

		/// <summary>
		/// Used by Threaded ports to determine if they should initiate an
		/// asynchronous update (still in development).
		/// </summary>
		// Token: 0x060001FD RID: 509 RVA: 0x00009ACC File Offset: 0x00007CCC
		public ulong GetUpdateTime()
		{
			return vtkDataObject.vtkDataObject_GetUpdateTime_49(base.GetCppThis());
		}

		// Token: 0x060001FE RID: 510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_GlobalReleaseDataFlagOff_50(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether every object releases its data
		/// after being used by a filter.
		/// </summary>
		// Token: 0x060001FF RID: 511 RVA: 0x00009AEB File Offset: 0x00007CEB
		public void GlobalReleaseDataFlagOff()
		{
			vtkDataObject.vtkDataObject_GlobalReleaseDataFlagOff_50(base.GetCppThis());
		}

		// Token: 0x06000200 RID: 512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_GlobalReleaseDataFlagOn_51(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether every object releases its data
		/// after being used by a filter.
		/// </summary>
		// Token: 0x06000201 RID: 513 RVA: 0x00009AFA File Offset: 0x00007CFA
		public void GlobalReleaseDataFlagOn()
		{
			vtkDataObject.vtkDataObject_GlobalReleaseDataFlagOn_51(base.GetCppThis());
		}

		// Token: 0x06000202 RID: 514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_Initialize_52(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state,
		/// </summary>
		// Token: 0x06000203 RID: 515 RVA: 0x00009B09 File Offset: 0x00007D09
		public virtual void Initialize()
		{
			vtkDataObject.vtkDataObject_Initialize_52(base.GetCppThis());
		}

		// Token: 0x06000204 RID: 516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_IsA_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000205 RID: 517 RVA: 0x00009B18 File Offset: 0x00007D18
		public override int IsA(string type)
		{
			return vtkDataObject.vtkDataObject_IsA_53(base.GetCppThis(), type);
		}

		// Token: 0x06000206 RID: 518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObject_IsTypeOf_54([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000207 RID: 519 RVA: 0x00009B38 File Offset: 0x00007D38
		public new static int IsTypeOf(string type)
		{
			return vtkDataObject.vtkDataObject_IsTypeOf_54(type);
		}

		// Token: 0x06000208 RID: 520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000209 RID: 521 RVA: 0x00009B54 File Offset: 0x00007D54
		public new vtkDataObject NewInstance()
		{
			vtkDataObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_NewInstance_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600020A RID: 522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_ORIGIN_57(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600020B RID: 523 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public static vtkInformationDoubleVectorKey ORIGIN()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_ORIGIN_57(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0600020C RID: 524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_PIECE_EXTENT_58(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600020D RID: 525 RVA: 0x00009C1C File Offset: 0x00007E1C
		public static vtkInformationIntegerVectorKey PIECE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_PIECE_EXTENT_58(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x0600020E RID: 526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_POINT_DATA_VECTOR_59(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600020F RID: 527 RVA: 0x00009C88 File Offset: 0x00007E88
		public static vtkInformationInformationVectorKey POINT_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_POINT_DATA_VECTOR_59(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x06000210 RID: 528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_PrepareForNewData_60(HandleRef pThis);

		/// <summary>
		/// make the output data ready for new data to be inserted. For most
		/// objects we just call Initialize. But for vtkImageData we leave the old
		/// data in case the memory can be reused.
		/// </summary>
		// Token: 0x06000211 RID: 529 RVA: 0x00009CF1 File Offset: 0x00007EF1
		public virtual void PrepareForNewData()
		{
			vtkDataObject.vtkDataObject_PrepareForNewData_60(base.GetCppThis());
		}

		// Token: 0x06000212 RID: 530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_ReleaseData_61(HandleRef pThis);

		/// <summary>
		/// Release data back to system to conserve memory resource. Used during
		/// visualization network execution.  Releasing this data does not make
		/// down-stream data invalid.
		/// </summary>
		// Token: 0x06000213 RID: 531 RVA: 0x00009D00 File Offset: 0x00007F00
		public void ReleaseData()
		{
			vtkDataObject.vtkDataObject_ReleaseData_61(base.GetCppThis());
		}

		// Token: 0x06000214 RID: 532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_RemoveNamedFieldInformation_62(HandleRef info, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove the info associated with an array
		/// </summary>
		// Token: 0x06000215 RID: 533 RVA: 0x00009D10 File Offset: 0x00007F10
		public static void RemoveNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
		{
			vtkDataObject.vtkDataObject_RemoveNamedFieldInformation_62((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, name);
		}

		// Token: 0x06000216 RID: 534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_SIL_63(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x06000217 RID: 535 RVA: 0x00009D3C File Offset: 0x00007F3C
		public static vtkInformationDataObjectKey SIL()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SIL_63(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x06000218 RID: 536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_SPACING_64(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x06000219 RID: 537 RVA: 0x00009DA8 File Offset: 0x00007FA8
		public static vtkInformationDoubleVectorKey SPACING()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SPACING_64(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0600021A RID: 538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600021B RID: 539 RVA: 0x00009E14 File Offset: 0x00008014
		public new static vtkDataObject SafeDownCast(vtkObjectBase o)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SafeDownCast_65((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600021C RID: 540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_SetActiveAttribute_66(HandleRef info, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeName, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the named array to be the active field for the specified type
		/// (SCALARS, VECTORS, NORMALS, TCOORDS, or TENSORS) and association
		/// (FIELD_ASSOCIATION_POINTS or FIELD_ASSOCIATION_CELLS).  Returns the
		/// active field information object and creates on entry if one not found.
		/// </summary>
		// Token: 0x0600021D RID: 541 RVA: 0x00009E94 File Offset: 0x00008094
		public static vtkInformation SetActiveAttribute(vtkInformation info, int fieldAssociation, string attributeName, int attributeType)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SetActiveAttribute_66((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeName, attributeType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0600021E RID: 542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_SetActiveAttributeInfo_67(HandleRef info, int fieldAssociation, int attributeType, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int arrayType, int numComponents, int numTuples);

		/// <summary>
		/// Set the name, array type, number of components, and number of tuples
		/// within the passed information object for the active attribute of type
		/// attributeType (in specified association, FIELD_ASSOCIATION_POINTS or
		/// FIELD_ASSOCIATION_CELLS).  If there is not an active attribute of the
		/// specified type, an entry in the information object is created.  If
		/// arrayType, numComponents, or numTuples equal to -1, or name=nullptr the
		/// value is not changed.
		/// </summary>
		// Token: 0x0600021F RID: 543 RVA: 0x00009F18 File Offset: 0x00008118
		public static void SetActiveAttributeInfo(vtkInformation info, int fieldAssociation, int attributeType, string name, int arrayType, int numComponents, int numTuples)
		{
			vtkDataObject.vtkDataObject_SetActiveAttributeInfo_67((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeType, name, arrayType, numComponents, numTuples);
		}

		// Token: 0x06000220 RID: 544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_SetFieldData_68(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign or retrieve a general field data to this data object.
		/// </summary>
		// Token: 0x06000221 RID: 545 RVA: 0x00009F4C File Offset: 0x0000814C
		public virtual void SetFieldData(vtkFieldData arg0)
		{
			vtkDataObject.vtkDataObject_SetFieldData_68(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000222 RID: 546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_SetGlobalReleaseDataFlag_69(int val);

		/// <summary>
		/// Turn on/off flag to control whether every object releases its data
		/// after being used by a filter.
		/// </summary>
		// Token: 0x06000223 RID: 547 RVA: 0x00009F7B File Offset: 0x0000817B
		public static void SetGlobalReleaseDataFlag(int val)
		{
			vtkDataObject.vtkDataObject_SetGlobalReleaseDataFlag_69(val);
		}

		// Token: 0x06000224 RID: 548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_SetInformation_70(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with this data object.
		/// </summary>
		// Token: 0x06000225 RID: 549 RVA: 0x00009F88 File Offset: 0x00008188
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkDataObject.vtkDataObject_SetInformation_70(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000226 RID: 550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_SetPointDataActiveScalarInfo_71(HandleRef info, int arrayType, int numComponents);

		/// <summary>
		/// Convenience version of previous method for use (primarily) by the Imaging
		/// filters. If arrayType or numComponents == -1, the value is not changed.
		/// </summary>
		// Token: 0x06000227 RID: 551 RVA: 0x00009FB8 File Offset: 0x000081B8
		public static void SetPointDataActiveScalarInfo(vtkInformation info, int arrayType, int numComponents)
		{
			vtkDataObject.vtkDataObject_SetPointDataActiveScalarInfo_71((info == null) ? default(HandleRef) : info.GetCppThis(), arrayType, numComponents);
		}

		// Token: 0x06000228 RID: 552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObject_ShallowCopy_72(HandleRef pThis, HandleRef src);

		/// <summary>
		/// The goal of the method is to copy the data up to the array pointers only.
		/// The implementation is delegated to the differenent subclasses.
		/// If you want to copy the actual data, @see DeepCopy.
		///
		/// This method shallow copy the field data and copy the internal structure.
		/// </summary>
		// Token: 0x06000229 RID: 553 RVA: 0x00009FE4 File Offset: 0x000081E4
		public virtual void ShallowCopy(vtkDataObject src)
		{
			vtkDataObject.vtkDataObject_ShallowCopy_72(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0600022A RID: 554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataObject_SupportsGhostArray_73(HandleRef pThis, int type);

		/// <summary>
		/// Returns if this type of data object support ghost array for specified type.
		/// The type may be:
		/// &lt;ul&gt;
		/// &lt;li&gt;POINT    - Defined in vtkDataSet subclasses
		/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
		/// &lt;/ul&gt;
		/// The other attribute types, will return false since
		/// ghosts arrays are not defined for now outside of point or cell.
		/// for vtkDataObject, this always return false but subclasses may override
		/// this method and implement their own logic.
		/// </summary>
		// Token: 0x0600022B RID: 555 RVA: 0x0000A014 File Offset: 0x00008214
		public virtual bool SupportsGhostArray(int type)
		{
			return vtkDataObject.vtkDataObject_SupportsGhostArray_73(base.GetCppThis(), type) != 0;
		}

		// Token: 0x0600022C RID: 556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObject_VERTEX_DATA_VECTOR_74(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a string association name, this static method returns an integer association type
		/// for the attribute (i.e. associationName = "Points": returns 0).
		/// </summary>
		// Token: 0x0600022D RID: 557 RVA: 0x0000A03C File Offset: 0x0000823C
		public static vtkInformationInformationVectorKey VERTEX_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObject.vtkDataObject_VERTEX_DATA_VECTOR_74(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000107 RID: 263
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObject";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000108 RID: 264
		public new static readonly string MRClassNameKey = "class vtkDataObject";

		/// <summary>
		/// Possible attribute types.
		/// POINT_THEN_CELL is provided for consistency with FieldAssociations.
		/// </summary>
		// Token: 0x02000007 RID: 7
		public enum AttributeTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400010A RID: 266
			CELL = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400010B RID: 267
			EDGE = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400010C RID: 268
			FIELD = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400010D RID: 269
			NUMBER_OF_ATTRIBUTE_TYPES = 7,
			/// <summary>enum member</summary>
			// Token: 0x0400010E RID: 270
			POINT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400010F RID: 271
			POINT_THEN_CELL = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000110 RID: 272
			ROW = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000111 RID: 273
			VERTEX = 4
		}

		/// <summary>
		/// Possible values for the FIELD_ASSOCIATION information entry.
		/// </summary>
		// Token: 0x02000008 RID: 8
		public enum FieldAssociations
		{
			/// <summary>enum member</summary>
			// Token: 0x04000113 RID: 275
			FIELD_ASSOCIATION_CELLS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000114 RID: 276
			FIELD_ASSOCIATION_EDGES = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000115 RID: 277
			FIELD_ASSOCIATION_NONE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000116 RID: 278
			FIELD_ASSOCIATION_POINTS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000117 RID: 279
			FIELD_ASSOCIATION_POINTS_THEN_CELLS = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000118 RID: 280
			FIELD_ASSOCIATION_ROWS = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000119 RID: 281
			FIELD_ASSOCIATION_VERTICES = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400011A RID: 282
			NUMBER_OF_ASSOCIATIONS = 7
		}

		/// <summary>
		/// Possible values for the FIELD_OPERATION information entry.
		/// </summary>
		// Token: 0x02000009 RID: 9
		public enum FieldOperations
		{
			/// <summary>enum member</summary>
			// Token: 0x0400011C RID: 284
			FIELD_OPERATION_MODIFIED = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400011D RID: 285
			FIELD_OPERATION_PRESERVED = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400011E RID: 286
			FIELD_OPERATION_REINTERPOLATED,
			/// <summary>enum member</summary>
			// Token: 0x0400011F RID: 287
			FIELD_OPERATION_REMOVED = 3
		}
	}
}
