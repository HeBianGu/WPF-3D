using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVariant
	/// </summary>
	/// <remarks>
	///    A type representing the union of many types.
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </remarks>
	// Token: 0x02000B84 RID: 2948
	public class vtkVariant : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EBF8 RID: 125944 RVA: 0x002B9BEF File Offset: 0x002B7DEF
		static vtkVariant()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVariant.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVariant"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBF9 RID: 125945 RVA: 0x002B9C17 File Offset: 0x002B7E17
		public vtkVariant(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBFA RID: 125946 RVA: 0x002B9C25 File Offset: 0x002B7E25
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EBFB RID: 125947
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariant_GetType_01(HandleRef pThis);

		/// <summary>
		/// Get the type of the variant.
		/// </summary>
		// Token: 0x0601EBFC RID: 125948 RVA: 0x002B9C30 File Offset: 0x002B7E30
		public uint GetTypeWrapper()
		{
			return vtkVariant.vtkVariant_GetType_01(base.GetCppThis());
		}

		// Token: 0x0601EBFD RID: 125949
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariant_GetTypeAsString_02(HandleRef pThis);

		/// <summary>
		/// Get the type of the variant as a string.
		/// </summary>
		// Token: 0x0601EBFE RID: 125950 RVA: 0x002B9C50 File Offset: 0x002B7E50
		public string GetTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkVariant.vtkVariant_GetTypeAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601EBFF RID: 125951
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsArray_03(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is a VTK array (i.e. vtkAbstractArray or a subclass thereof).
		/// </summary>
		// Token: 0x0601EC00 RID: 125952 RVA: 0x002B9C8C File Offset: 0x002B7E8C
		public bool IsArray()
		{
			return vtkVariant.vtkVariant_IsArray_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC01 RID: 125953
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsChar_04(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an char.
		/// </summary>
		// Token: 0x0601EC02 RID: 125954 RVA: 0x002B9CB4 File Offset: 0x002B7EB4
		public bool IsChar()
		{
			return vtkVariant.vtkVariant_IsChar_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC03 RID: 125955
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsDouble_05(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is a double.
		/// </summary>
		// Token: 0x0601EC04 RID: 125956 RVA: 0x002B9CDC File Offset: 0x002B7EDC
		public bool IsDouble()
		{
			return vtkVariant.vtkVariant_IsDouble_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC05 RID: 125957
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsEqual_06(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Determines whether two variants have the same value. They do
		/// not need to be storing exactly the same type to have the same
		/// value.  In practice you don't need to use this method: just use
		/// operator== instead.  If you want precise equality down to the bit
		/// level use the following idiom:
		///
		/// vtkVariantStrictEquality comparator;
		/// bool variantsEqual = comparator(firstVariant, secondVariant);
		/// </summary>
		// Token: 0x0601EC06 RID: 125958 RVA: 0x002B9D04 File Offset: 0x002B7F04
		public bool IsEqual(vtkVariant other)
		{
			return vtkVariant.vtkVariant_IsEqual_06(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		// Token: 0x0601EC07 RID: 125959
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsFloat_07(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is a float.
		/// </summary>
		// Token: 0x0601EC08 RID: 125960 RVA: 0x002B9D40 File Offset: 0x002B7F40
		public bool IsFloat()
		{
			return vtkVariant.vtkVariant_IsFloat_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC09 RID: 125961
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsInt_08(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an int.
		/// </summary>
		// Token: 0x0601EC0A RID: 125962 RVA: 0x002B9D68 File Offset: 0x002B7F68
		public bool IsInt()
		{
			return vtkVariant.vtkVariant_IsInt_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC0B RID: 125963
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsLong_09(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an long.
		/// </summary>
		// Token: 0x0601EC0C RID: 125964 RVA: 0x002B9D90 File Offset: 0x002B7F90
		public bool IsLong()
		{
			return vtkVariant.vtkVariant_IsLong_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC0D RID: 125965
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsLongLong_10(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is long long.
		/// </summary>
		// Token: 0x0601EC0E RID: 125966 RVA: 0x002B9DB8 File Offset: 0x002B7FB8
		public bool IsLongLong()
		{
			return vtkVariant.vtkVariant_IsLongLong_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC0F RID: 125967
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsNumeric_11(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is any numeric type.
		/// </summary>
		// Token: 0x0601EC10 RID: 125968 RVA: 0x002B9DE0 File Offset: 0x002B7FE0
		public bool IsNumeric()
		{
			return vtkVariant.vtkVariant_IsNumeric_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC11 RID: 125969
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsShort_12(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an short.
		/// </summary>
		// Token: 0x0601EC12 RID: 125970 RVA: 0x002B9E08 File Offset: 0x002B8008
		public bool IsShort()
		{
			return vtkVariant.vtkVariant_IsShort_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC13 RID: 125971
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsSignedChar_13(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an signed char.
		/// </summary>
		// Token: 0x0601EC14 RID: 125972 RVA: 0x002B9E30 File Offset: 0x002B8030
		public bool IsSignedChar()
		{
			return vtkVariant.vtkVariant_IsSignedChar_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC15 RID: 125973
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsString_14(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is a string.
		/// </summary>
		// Token: 0x0601EC16 RID: 125974 RVA: 0x002B9E58 File Offset: 0x002B8058
		public bool IsString()
		{
			return vtkVariant.vtkVariant_IsString_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC17 RID: 125975
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsUnsignedChar_15(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an unsigned char.
		/// </summary>
		// Token: 0x0601EC18 RID: 125976 RVA: 0x002B9E80 File Offset: 0x002B8080
		public bool IsUnsignedChar()
		{
			return vtkVariant.vtkVariant_IsUnsignedChar_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC19 RID: 125977
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsUnsignedInt_16(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an unsigned int.
		/// </summary>
		// Token: 0x0601EC1A RID: 125978 RVA: 0x002B9EA8 File Offset: 0x002B80A8
		public bool IsUnsignedInt()
		{
			return vtkVariant.vtkVariant_IsUnsignedInt_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC1B RID: 125979
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsUnsignedLong_17(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an unsigned long.
		/// </summary>
		// Token: 0x0601EC1C RID: 125980 RVA: 0x002B9ED0 File Offset: 0x002B80D0
		public bool IsUnsignedLong()
		{
			return vtkVariant.vtkVariant_IsUnsignedLong_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC1D RID: 125981
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsUnsignedLongLong_18(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is unsigned long long.
		/// </summary>
		// Token: 0x0601EC1E RID: 125982 RVA: 0x002B9EF8 File Offset: 0x002B80F8
		public bool IsUnsignedLongLong()
		{
			return vtkVariant.vtkVariant_IsUnsignedLongLong_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC1F RID: 125983
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsUnsignedShort_19(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is an unsigned short.
		/// </summary>
		// Token: 0x0601EC20 RID: 125984 RVA: 0x002B9F20 File Offset: 0x002B8120
		public bool IsUnsignedShort()
		{
			return vtkVariant.vtkVariant_IsUnsignedShort_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC21 RID: 125985
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsVTKObject_20(HandleRef pThis);

		/// <summary>
		/// Get whether the variant is a VTK object pointer (i.e. vtkObjectBase or a subclass thereof).
		/// </summary>
		// Token: 0x0601EC22 RID: 125986 RVA: 0x002B9F48 File Offset: 0x002B8148
		public bool IsVTKObject()
		{
			return vtkVariant.vtkVariant_IsVTKObject_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC23 RID: 125987
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_IsValid_21(HandleRef pThis);

		/// <summary>
		/// Get whether the variant value is valid. Simple scalar types are always considered valid.
		/// Strings and pointers are considered valid only if non-nullptr.
		/// </summary>
		// Token: 0x0601EC24 RID: 125988 RVA: 0x002B9F70 File Offset: 0x002B8170
		public bool IsValid()
		{
			return vtkVariant.vtkVariant_IsValid_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EC25 RID: 125989
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariant_ToArray_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array, or nullptr if not of that type.
		/// </summary>
		// Token: 0x0601EC26 RID: 125990 RVA: 0x002B9F98 File Offset: 0x002B8198
		public vtkAbstractArray ToArray()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariant.vtkVariant_ToArray_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EC27 RID: 125991
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkVariant_ToChar_23(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC28 RID: 125992 RVA: 0x002BA008 File Offset: 0x002B8208
		public sbyte ToChar(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToChar_23(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC29 RID: 125993
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkVariant_ToChar_24(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC2A RID: 125994 RVA: 0x002BA028 File Offset: 0x002B8228
		public sbyte ToChar()
		{
			return vtkVariant.vtkVariant_ToChar_24(base.GetCppThis());
		}

		// Token: 0x0601EC2B RID: 125995
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVariant_ToDouble_25(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC2C RID: 125996 RVA: 0x002BA048 File Offset: 0x002B8248
		public double ToDouble(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToDouble_25(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC2D RID: 125997
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVariant_ToDouble_26(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC2E RID: 125998 RVA: 0x002BA068 File Offset: 0x002B8268
		public double ToDouble()
		{
			return vtkVariant.vtkVariant_ToDouble_26(base.GetCppThis());
		}

		// Token: 0x0601EC2F RID: 125999
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVariant_ToFloat_27(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC30 RID: 126000 RVA: 0x002BA088 File Offset: 0x002B8288
		public float ToFloat(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToFloat_27(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC31 RID: 126001
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVariant_ToFloat_28(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC32 RID: 126002 RVA: 0x002BA0A8 File Offset: 0x002B82A8
		public float ToFloat()
		{
			return vtkVariant.vtkVariant_ToFloat_28(base.GetCppThis());
		}

		// Token: 0x0601EC33 RID: 126003
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariant_ToInt_29(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC34 RID: 126004 RVA: 0x002BA0C8 File Offset: 0x002B82C8
		public int ToInt(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToInt_29(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC35 RID: 126005
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariant_ToInt_30(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC36 RID: 126006 RVA: 0x002BA0E8 File Offset: 0x002B82E8
		public int ToInt()
		{
			return vtkVariant.vtkVariant_ToInt_30(base.GetCppThis());
		}

		// Token: 0x0601EC37 RID: 126007
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariant_ToLong_31(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC38 RID: 126008 RVA: 0x002BA108 File Offset: 0x002B8308
		public int ToLong(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToLong_31(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC39 RID: 126009
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariant_ToLong_32(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC3A RID: 126010 RVA: 0x002BA128 File Offset: 0x002B8328
		public int ToLong()
		{
			return vtkVariant.vtkVariant_ToLong_32(base.GetCppThis());
		}

		// Token: 0x0601EC3B RID: 126011
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariant_ToLongLong_33(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC3C RID: 126012 RVA: 0x002BA148 File Offset: 0x002B8348
		public long ToLongLong(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToLongLong_33(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC3D RID: 126013
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariant_ToLongLong_34(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC3E RID: 126014 RVA: 0x002BA168 File Offset: 0x002B8368
		public long ToLongLong()
		{
			return vtkVariant.vtkVariant_ToLongLong_34(base.GetCppThis());
		}

		// Token: 0x0601EC3F RID: 126015
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkVariant_ToShort_35(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC40 RID: 126016 RVA: 0x002BA188 File Offset: 0x002B8388
		public short ToShort(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToShort_35(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC41 RID: 126017
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkVariant_ToShort_36(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC42 RID: 126018 RVA: 0x002BA1A8 File Offset: 0x002B83A8
		public short ToShort()
		{
			return vtkVariant.vtkVariant_ToShort_36(base.GetCppThis());
		}

		// Token: 0x0601EC43 RID: 126019
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkVariant_ToSignedChar_37(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC44 RID: 126020 RVA: 0x002BA1C8 File Offset: 0x002B83C8
		public sbyte ToSignedChar(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToSignedChar_37(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC45 RID: 126021
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkVariant_ToSignedChar_38(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC46 RID: 126022 RVA: 0x002BA1E8 File Offset: 0x002B83E8
		public sbyte ToSignedChar()
		{
			return vtkVariant.vtkVariant_ToSignedChar_38(base.GetCppThis());
		}

		// Token: 0x0601EC47 RID: 126023
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVariant_ToString_39(HandleRef pThis, int formatting, int precision);

		/// <summary>
		/// Convert the variant to a string.
		/// Set the formatting argument to either DEFAULT_FORMATTING, FIXED_FORMATTING,
		/// SCIENTIFIC_FORMATTING to control the formatting. Set the precision
		/// argument to control the precision of the output. These two parameters have no effect when the
		/// variant is not a floating-point value or an array of floating-point values.
		/// See the std doc for more information.
		/// </summary>
		// Token: 0x0601EC48 RID: 126024 RVA: 0x002BA208 File Offset: 0x002B8408
		public string ToStringWrapper(int formatting, int precision)
		{
			return vtkVariant.vtkVariant_ToString_39(base.GetCppThis(), formatting, precision);
		}

		// Token: 0x0601EC49 RID: 126025
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariant_ToTypeInt64_40(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC4A RID: 126026 RVA: 0x002BA22C File Offset: 0x002B842C
		public long ToTypeInt64(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToTypeInt64_40(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC4B RID: 126027
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariant_ToTypeInt64_41(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC4C RID: 126028 RVA: 0x002BA24C File Offset: 0x002B844C
		public long ToTypeInt64()
		{
			return vtkVariant.vtkVariant_ToTypeInt64_41(base.GetCppThis());
		}

		// Token: 0x0601EC4D RID: 126029
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVariant_ToTypeUInt64_42(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC4E RID: 126030 RVA: 0x002BA26C File Offset: 0x002B846C
		public ulong ToTypeUInt64(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToTypeUInt64_42(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC4F RID: 126031
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVariant_ToTypeUInt64_43(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC50 RID: 126032 RVA: 0x002BA28C File Offset: 0x002B848C
		public ulong ToTypeUInt64()
		{
			return vtkVariant.vtkVariant_ToTypeUInt64_43(base.GetCppThis());
		}

		// Token: 0x0601EC51 RID: 126033
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_ToUnsignedChar_44(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC52 RID: 126034 RVA: 0x002BA2AC File Offset: 0x002B84AC
		public byte ToUnsignedChar(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToUnsignedChar_44(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC53 RID: 126035
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVariant_ToUnsignedChar_45(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC54 RID: 126036 RVA: 0x002BA2CC File Offset: 0x002B84CC
		public byte ToUnsignedChar()
		{
			return vtkVariant.vtkVariant_ToUnsignedChar_45(base.GetCppThis());
		}

		// Token: 0x0601EC55 RID: 126037
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariant_ToUnsignedInt_46(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC56 RID: 126038 RVA: 0x002BA2EC File Offset: 0x002B84EC
		public uint ToUnsignedInt(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToUnsignedInt_46(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC57 RID: 126039
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariant_ToUnsignedInt_47(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC58 RID: 126040 RVA: 0x002BA30C File Offset: 0x002B850C
		public uint ToUnsignedInt()
		{
			return vtkVariant.vtkVariant_ToUnsignedInt_47(base.GetCppThis());
		}

		// Token: 0x0601EC59 RID: 126041
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariant_ToUnsignedLong_48(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC5A RID: 126042 RVA: 0x002BA32C File Offset: 0x002B852C
		public uint ToUnsignedLong(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToUnsignedLong_48(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC5B RID: 126043
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariant_ToUnsignedLong_49(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC5C RID: 126044 RVA: 0x002BA34C File Offset: 0x002B854C
		public uint ToUnsignedLong()
		{
			return vtkVariant.vtkVariant_ToUnsignedLong_49(base.GetCppThis());
		}

		// Token: 0x0601EC5D RID: 126045
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVariant_ToUnsignedLongLong_50(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC5E RID: 126046 RVA: 0x002BA36C File Offset: 0x002B856C
		public ulong ToUnsignedLongLong(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToUnsignedLongLong_50(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC5F RID: 126047
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVariant_ToUnsignedLongLong_51(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC60 RID: 126048 RVA: 0x002BA38C File Offset: 0x002B858C
		public ulong ToUnsignedLongLong()
		{
			return vtkVariant.vtkVariant_ToUnsignedLongLong_51(base.GetCppThis());
		}

		// Token: 0x0601EC61 RID: 126049
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkVariant_ToUnsignedShort_52(HandleRef pThis, IntPtr valid);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC62 RID: 126050 RVA: 0x002BA3AC File Offset: 0x002B85AC
		public ushort ToUnsignedShort(IntPtr valid)
		{
			return vtkVariant.vtkVariant_ToUnsignedShort_52(base.GetCppThis(), valid);
		}

		// Token: 0x0601EC63 RID: 126051
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkVariant_ToUnsignedShort_53(HandleRef pThis);

		/// <summary>
		/// Convert the variant to a numeric type:
		/// If it holds a numeric, cast to the appropriate type.
		/// If it holds a string, attempt to convert the string to the appropriate type;
		/// set the valid flag to false when the conversion fails.
		/// If it holds an array type, cast the first value of the array
		/// to the appropriate type.
		/// Fail if it holds a VTK object which is not an array.
		/// </summary>
		// Token: 0x0601EC64 RID: 126052 RVA: 0x002BA3CC File Offset: 0x002B85CC
		public ushort ToUnsignedShort()
		{
			return vtkVariant.vtkVariant_ToUnsignedShort_53(base.GetCppThis());
		}

		// Token: 0x0601EC65 RID: 126053
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariant_ToVTKObject_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the VTK object, or nullptr if not of that type.
		/// </summary>
		// Token: 0x0601EC66 RID: 126054 RVA: 0x002BA3EC File Offset: 0x002B85EC
		public vtkObjectBase ToVTKObject()
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariant.vtkVariant_ToVTKObject_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		// Token: 0x0601EC67 RID: 126055
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariant_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float v);

		// Token: 0x0601EC68 RID: 126056 RVA: 0x002BA45C File Offset: 0x002B865C
		public vtkVariant(float v) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVariant.vtkVariant_New(ref num, ref maxValue, ref num2, v);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020F3 RID: 8435
		public new const string MRFullTypeName = "Kitware.VTK.vtkVariant";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020F4 RID: 8436
		public new static readonly string MRClassNameKey = "class vtkVariant";

		/// <summary>
		/// Get the type of the variant as a string.
		/// </summary>
		// Token: 0x02000B85 RID: 2949
		public enum StringFormatting
		{
			/// <summary>enum member</summary>
			// Token: 0x040020F6 RID: 8438
			DEFAULT_FORMATTING,
			/// <summary>enum member</summary>
			// Token: 0x040020F7 RID: 8439
			FIXED_FORMATTING,
			/// <summary>enum member</summary>
			// Token: 0x040020F8 RID: 8440
			SCIENTIFIC_FORMATTING
		}
	}
}
