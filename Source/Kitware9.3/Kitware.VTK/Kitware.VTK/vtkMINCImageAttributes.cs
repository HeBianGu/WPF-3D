using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMINCImageAttributes
	/// </summary>
	/// <remarks>
	///    A container for a MINC image header.
	///
	/// This class provides methods to access all of the information
	/// contained in the MINC header.  If you read a MINC file into
	/// VTK and then write it out again, you can use
	/// writer-&gt;SetImageAttributes(reader-&gt;GetImageAttributes) to
	/// ensure that all of the medical information contained in the
	/// file is transferred from the reader to the writer.  If you
	/// want to change any of the header information, you must
	/// use ShallowCopy to make a copy of the reader's attributes
	/// and then modify only the copy.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMINCImageWriter
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x02000178 RID: 376
	public class vtkMINCImageAttributes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004794 RID: 18324 RVA: 0x000681C3 File Offset: 0x000663C3
		static vtkMINCImageAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004795 RID: 18325 RVA: 0x000681EB File Offset: 0x000663EB
		public vtkMINCImageAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004796 RID: 18326
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004797 RID: 18327 RVA: 0x000681FC File Offset: 0x000663FC
		public new static vtkMINCImageAttributes New()
		{
			vtkMINCImageAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004798 RID: 18328 RVA: 0x00068250 File Offset: 0x00066450
		public vtkMINCImageAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMINCImageAttributes.vtkMINCImageAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004799 RID: 18329 RVA: 0x00068294 File Offset: 0x00066494
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600479A RID: 18330
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_AddDimension_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dimension);

		/// <summary>
		/// Add the names of up to five dimensions. The ordering of these
		/// dimensions will determine the dimension order of the file.  If
		/// no DimensionNames are set, the writer will set the dimension
		/// order of the file to be the same as the dimension order in memory.
		/// </summary>
		// Token: 0x0600479B RID: 18331 RVA: 0x0006829F File Offset: 0x0006649F
		public virtual void AddDimension(string dimension)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_AddDimension_01(base.GetCppThis(), dimension);
		}

		// Token: 0x0600479C RID: 18332
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_AddDimension_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dimension, long length);

		/// <summary>
		/// Add the names of up to five dimensions. The ordering of these
		/// dimensions will determine the dimension order of the file.  If
		/// no DimensionNames are set, the writer will set the dimension
		/// order of the file to be the same as the dimension order in memory.
		/// </summary>
		// Token: 0x0600479D RID: 18333 RVA: 0x000682AF File Offset: 0x000664AF
		public virtual void AddDimension(string dimension, long length)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_AddDimension_02(base.GetCppThis(), dimension, length);
		}

		// Token: 0x0600479E RID: 18334
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_FindImageRange_03(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Find the image range of the data from the information stored
		/// in the attributes.
		/// </summary>
		// Token: 0x0600479F RID: 18335 RVA: 0x000682C0 File Offset: 0x000664C0
		public virtual void FindImageRange(IntPtr range)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_FindImageRange_03(base.GetCppThis(), range);
		}

		// Token: 0x060047A0 RID: 18336
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_FindValidRange_04(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Find the valid range of the data from the information stored
		/// in the attributes.
		/// </summary>
		// Token: 0x060047A1 RID: 18337 RVA: 0x000682D0 File Offset: 0x000664D0
		public virtual void FindValidRange(IntPtr range)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_FindValidRange_04(base.GetCppThis(), range);
		}

		// Token: 0x060047A2 RID: 18338
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeNames_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// List the attribute names for a variable.  Set the variable
		/// to the empty string to get a list of the global attributes.
		/// </summary>
		// Token: 0x060047A3 RID: 18339 RVA: 0x000682E0 File Offset: 0x000664E0
		public virtual vtkStringArray GetAttributeNames(string variable)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeNames_05(base.GetCppThis(), variable, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060047A4 RID: 18340
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsArray_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set attribute values for a variable as a vtkDataArray.
		/// Set the variable to the empty string to access global attributes.
		/// </summary>
		// Token: 0x060047A5 RID: 18341 RVA: 0x00068350 File Offset: 0x00066550
		public virtual vtkDataArray GetAttributeValueAsArray(string variable, string attribute)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsArray_06(base.GetCppThis(), variable, attribute, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060047A6 RID: 18342
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMINCImageAttributes_GetAttributeValueAsDouble_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Set an attribute value as a double.  Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047A7 RID: 18343 RVA: 0x000683C4 File Offset: 0x000665C4
		public virtual double GetAttributeValueAsDouble(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsDouble_07(base.GetCppThis(), variable, attribute);
		}

		// Token: 0x060047A8 RID: 18344
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_GetAttributeValueAsInt_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Set an attribute value as an int. Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047A9 RID: 18345 RVA: 0x000683E8 File Offset: 0x000665E8
		public virtual int GetAttributeValueAsInt(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsInt_08(base.GetCppThis(), variable, attribute);
		}

		// Token: 0x060047AA RID: 18346
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsString_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Set an attribute value as a string.  Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047AB RID: 18347 RVA: 0x0006840C File Offset: 0x0006660C
		public virtual string GetAttributeValueAsString(string variable, string attribute)
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageAttributes.vtkMINCImageAttributes_GetAttributeValueAsString_09(base.GetCppThis(), variable, attribute));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060047AC RID: 18348
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_GetDataType_10(HandleRef pThis);

		/// <summary>
		/// Get the image data type, as stored on disk.  This information
		/// is useful if the file was converted to floating-point when it
		/// was loaded.  When writing a file from float or double image data,
		/// you can use this method to prescribe the output type.
		/// </summary>
		// Token: 0x060047AD RID: 18349 RVA: 0x00068448 File Offset: 0x00066648
		public virtual int GetDataType()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetDataType_10(base.GetCppThis());
		}

		// Token: 0x060047AE RID: 18350
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetDimensionLengths_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the lengths of all the dimensions.  The dimension lengths
		/// are informative, the vtkMINCImageWriter does not look at these values
		/// but instead uses the dimension sizes of its input.
		/// </summary>
		// Token: 0x060047AF RID: 18351 RVA: 0x00068468 File Offset: 0x00066668
		public virtual vtkIdTypeArray GetDimensionLengths()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetDimensionLengths_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x060047B0 RID: 18352
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetDimensionNames_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the dimension names.  The dimension names are same order
		/// as written in the file, starting with the slowest-varying
		/// dimension.  Use this method to get the array if you need to
		/// change "space" dimensions to "frequency" after performing a
		/// Fourier transform.
		/// </summary>
		// Token: 0x060047B1 RID: 18353 RVA: 0x000684D8 File Offset: 0x000666D8
		public virtual vtkStringArray GetDimensionNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetDimensionNames_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060047B2 RID: 18354
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetImageMax_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the image min and max arrays. These are set by the reader,
		/// but they aren't used by the writer except to compute the full
		/// real data range of the original file.
		/// </summary>
		// Token: 0x060047B3 RID: 18355 RVA: 0x00068548 File Offset: 0x00066748
		public virtual vtkDoubleArray GetImageMax()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetImageMax_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060047B4 RID: 18356
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetImageMin_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the image min and max arrays. These are set by the reader,
		/// but they aren't used by the writer except to compute the full
		/// real data range of the original file.
		/// </summary>
		// Token: 0x060047B5 RID: 18357 RVA: 0x000685B8 File Offset: 0x000667B8
		public virtual vtkDoubleArray GetImageMin()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetImageMin_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060047B6 RID: 18358
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetName_15(HandleRef pThis);

		/// <summary>
		/// Get the name of the image, not including the path or
		/// the extension.  This is only needed for printing the
		/// header and there is usually no need to set it.
		/// </summary>
		// Token: 0x060047B7 RID: 18359 RVA: 0x00068628 File Offset: 0x00066828
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageAttributes.vtkMINCImageAttributes_GetName_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060047B8 RID: 18360
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageAttributes_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047B9 RID: 18361 RVA: 0x00068664 File Offset: 0x00066864
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060047BA RID: 18362
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageAttributes_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047BB RID: 18363 RVA: 0x00068684 File Offset: 0x00066884
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060047BC RID: 18364
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_18(HandleRef pThis);

		/// <summary>
		/// Get the number of ImageMinMax dimensions.
		/// </summary>
		// Token: 0x060047BD RID: 18365 RVA: 0x000686A0 File Offset: 0x000668A0
		public virtual int GetNumberOfImageMinMaxDimensions()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_18(base.GetCppThis());
		}

		// Token: 0x060047BE RID: 18366
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_GetValidateAttributes_19(HandleRef pThis);

		/// <summary>
		/// Set this to Off if you do not want to automatically validate
		/// every attribute that is set.
		/// </summary>
		// Token: 0x060047BF RID: 18367 RVA: 0x000686C0 File Offset: 0x000668C0
		public virtual int GetValidateAttributes()
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_GetValidateAttributes_19(base.GetCppThis());
		}

		// Token: 0x060047C0 RID: 18368
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_GetVariableNames_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the names of all the variables.
		/// </summary>
		// Token: 0x060047C1 RID: 18369 RVA: 0x000686E0 File Offset: 0x000668E0
		public virtual vtkStringArray GetVariableNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_GetVariableNames_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060047C2 RID: 18370
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_HasAttribute_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Check to see if a particular attribute exists.
		/// </summary>
		// Token: 0x060047C3 RID: 18371 RVA: 0x00068750 File Offset: 0x00066950
		public virtual int HasAttribute(string variable, string attribute)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_HasAttribute_21(base.GetCppThis(), variable, attribute);
		}

		// Token: 0x060047C4 RID: 18372
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047C5 RID: 18373 RVA: 0x00068774 File Offset: 0x00066974
		public override int IsA(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060047C6 RID: 18374
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047C7 RID: 18375 RVA: 0x00068794 File Offset: 0x00066994
		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_IsTypeOf_23(type);
		}

		// Token: 0x060047C8 RID: 18376
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047C9 RID: 18377 RVA: 0x000687B0 File Offset: 0x000669B0
		public new vtkMINCImageAttributes NewInstance()
		{
			vtkMINCImageAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060047CA RID: 18378
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_PrintFileHeader_26(HandleRef pThis);

		/// <summary>
		/// A diagnostic function.  Print the header of the file in
		/// the same format as ncdump or mincheader.
		/// </summary>
		// Token: 0x060047CB RID: 18379 RVA: 0x0006880A File Offset: 0x00066A0A
		public virtual void PrintFileHeader()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_PrintFileHeader_26(base.GetCppThis());
		}

		// Token: 0x060047CC RID: 18380
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_Reset_27(HandleRef pThis);

		/// <summary>
		/// Reset all the attributes in preparation for loading
		/// new information.
		/// </summary>
		// Token: 0x060047CD RID: 18381 RVA: 0x00068819 File Offset: 0x00066A19
		public virtual void Reset()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_Reset_27(base.GetCppThis());
		}

		// Token: 0x060047CE RID: 18382
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageAttributes_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047CF RID: 18383 RVA: 0x00068828 File Offset: 0x00066A28
		public new static vtkMINCImageAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageAttributes.vtkMINCImageAttributes_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		// Token: 0x060047D0 RID: 18384
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsArray_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, HandleRef array);

		/// <summary>
		/// Set attribute values for a variable as a vtkDataArray.
		/// Set the variable to the empty string to access global attributes.
		/// </summary>
		// Token: 0x060047D1 RID: 18385 RVA: 0x000688A8 File Offset: 0x00066AA8
		public virtual void SetAttributeValueAsArray(string variable, string attribute, vtkDataArray array)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsArray_29(base.GetCppThis(), variable, attribute, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x060047D2 RID: 18386
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsDouble_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, double value);

		/// <summary>
		/// Set an attribute value as a double.  Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047D3 RID: 18387 RVA: 0x000688D9 File Offset: 0x00066AD9
		public virtual void SetAttributeValueAsDouble(string variable, string attribute, double value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsDouble_30(base.GetCppThis(), variable, attribute, value);
		}

		// Token: 0x060047D4 RID: 18388
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsInt_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, int value);

		/// <summary>
		/// Set an attribute value as an int. Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047D5 RID: 18389 RVA: 0x000688EB File Offset: 0x00066AEB
		public virtual void SetAttributeValueAsInt(string variable, string attribute, int value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsInt_31(base.GetCppThis(), variable, attribute, value);
		}

		// Token: 0x060047D6 RID: 18390
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetAttributeValueAsString_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variable, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Set an attribute value as a string.  Set the variable
		/// to the empty string to access global attributes.
		/// If you specify a variable that does not exist, it will be
		/// created.
		/// </summary>
		// Token: 0x060047D7 RID: 18391 RVA: 0x000688FD File Offset: 0x00066AFD
		public virtual void SetAttributeValueAsString(string variable, string attribute, string value)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetAttributeValueAsString_32(base.GetCppThis(), variable, attribute, value);
		}

		// Token: 0x060047D8 RID: 18392
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetDataType_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the image data type, as stored on disk.  This information
		/// is useful if the file was converted to floating-point when it
		/// was loaded.  When writing a file from float or double image data,
		/// you can use this method to prescribe the output type.
		/// </summary>
		// Token: 0x060047D9 RID: 18393 RVA: 0x0006890F File Offset: 0x00066B0F
		public virtual void SetDataType(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetDataType_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060047DA RID: 18394
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetImageMax_34(HandleRef pThis, HandleRef imageMax);

		/// <summary>
		/// Get the image min and max arrays. These are set by the reader,
		/// but they aren't used by the writer except to compute the full
		/// real data range of the original file.
		/// </summary>
		// Token: 0x060047DB RID: 18395 RVA: 0x00068920 File Offset: 0x00066B20
		public virtual void SetImageMax(vtkDoubleArray imageMax)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetImageMax_34(base.GetCppThis(), (imageMax == null) ? default(HandleRef) : imageMax.GetCppThis());
		}

		// Token: 0x060047DC RID: 18396
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetImageMin_35(HandleRef pThis, HandleRef imageMin);

		/// <summary>
		/// Get the image min and max arrays. These are set by the reader,
		/// but they aren't used by the writer except to compute the full
		/// real data range of the original file.
		/// </summary>
		// Token: 0x060047DD RID: 18397 RVA: 0x00068950 File Offset: 0x00066B50
		public virtual void SetImageMin(vtkDoubleArray imageMin)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetImageMin_35(base.GetCppThis(), (imageMin == null) ? default(HandleRef) : imageMin.GetCppThis());
		}

		// Token: 0x060047DE RID: 18398
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetName_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get the name of the image, not including the path or
		/// the extension.  This is only needed for printing the
		/// header and there is usually no need to set it.
		/// </summary>
		// Token: 0x060047DF RID: 18399 RVA: 0x0006897F File Offset: 0x00066B7F
		public virtual void SetName(string _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetName_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060047E0 RID: 18400
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the number of ImageMinMax dimensions.
		/// </summary>
		// Token: 0x060047E1 RID: 18401 RVA: 0x0006898F File Offset: 0x00066B8F
		public virtual void SetNumberOfImageMinMaxDimensions(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060047E2 RID: 18402
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_SetValidateAttributes_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set this to Off if you do not want to automatically validate
		/// every attribute that is set.
		/// </summary>
		// Token: 0x060047E3 RID: 18403 RVA: 0x0006899F File Offset: 0x00066B9F
		public virtual void SetValidateAttributes(int _arg)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_SetValidateAttributes_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060047E4 RID: 18404
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_ShallowCopy_39(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Do a shallow copy.  This will copy all the attributes
		/// from the source.  It is much more efficient than a DeepCopy
		/// would be, since it only copies pointers to the attribute values
		/// instead of copying the arrays themselves.  You must use this
		/// method to make a copy if you want to modify any MINC attributes
		/// from a MINCReader before you pass them to a MINCWriter.
		/// </summary>
		// Token: 0x060047E5 RID: 18405 RVA: 0x000689B0 File Offset: 0x00066BB0
		public virtual void ShallowCopy(vtkMINCImageAttributes source)
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ShallowCopy_39(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x060047E6 RID: 18406
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageAttributes_ValidateAttribute_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string varname, [MarshalAs(UnmanagedType.LPUTF8Str)] string attname, HandleRef array);

		/// <summary>
		/// Validate a particular attribute.  This involves checking
		/// that the attribute is a MINC standard attribute, and checking
		/// whether it can be set (as opposed to being set automatically
		/// from the image information).  The return values is 0 if
		/// the attribute is set automatically and therefore should not
		/// be copied from here, 1 if this attribute is valid and should
		/// be set, and 2 if the attribute is non-standard.
		/// </summary>
		// Token: 0x060047E7 RID: 18407 RVA: 0x000689E0 File Offset: 0x00066BE0
		public virtual int ValidateAttribute(string varname, string attname, vtkDataArray array)
		{
			return vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttribute_40(base.GetCppThis(), varname, attname, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x060047E8 RID: 18408
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_ValidateAttributesOff_41(HandleRef pThis);

		/// <summary>
		/// Set this to Off if you do not want to automatically validate
		/// every attribute that is set.
		/// </summary>
		// Token: 0x060047E9 RID: 18409 RVA: 0x00068A16 File Offset: 0x00066C16
		public virtual void ValidateAttributesOff()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttributesOff_41(base.GetCppThis());
		}

		// Token: 0x060047EA RID: 18410
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageAttributes_ValidateAttributesOn_42(HandleRef pThis);

		/// <summary>
		/// Set this to Off if you do not want to automatically validate
		/// every attribute that is set.
		/// </summary>
		// Token: 0x060047EB RID: 18411 RVA: 0x00068A25 File Offset: 0x00066C25
		public virtual void ValidateAttributesOn()
		{
			vtkMINCImageAttributes.vtkMINCImageAttributes_ValidateAttributesOn_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000741 RID: 1857
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000742 RID: 1858
		public new static readonly string MRClassNameKey = "class vtkMINCImageAttributes";
	}
}
