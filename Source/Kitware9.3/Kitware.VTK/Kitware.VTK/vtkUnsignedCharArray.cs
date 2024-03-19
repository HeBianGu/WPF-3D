using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedCharArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of unsigned char
	///
	/// vtkUnsignedCharArray is an array of values of type unsigned char.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	/// </remarks>
	// Token: 0x02000B31 RID: 2865
	public class vtkUnsignedCharArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E080 RID: 123008 RVA: 0x002A6F23 File Offset: 0x002A5123
		static vtkUnsignedCharArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedCharArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E081 RID: 123009 RVA: 0x002A6F4B File Offset: 0x002A514B
		public vtkUnsignedCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E082 RID: 123010
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E083 RID: 123011 RVA: 0x002A6F5C File Offset: 0x002A515C
		public new static vtkUnsignedCharArray New()
		{
			vtkUnsignedCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E084 RID: 123012 RVA: 0x002A6FB0 File Offset: 0x002A51B0
		public vtkUnsignedCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedCharArray.vtkUnsignedCharArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E085 RID: 123013 RVA: 0x002A6FF4 File Offset: 0x002A51F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E086 RID: 123014
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedCharArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E087 RID: 123015 RVA: 0x002A7000 File Offset: 0x002A5200
		public static vtkUnsignedCharArray ExtendedNew()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E088 RID: 123016
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedCharArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E089 RID: 123017 RVA: 0x002A706C File Offset: 0x002A526C
		public new static vtkUnsignedCharArray FastDownCast(vtkAbstractArray source)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E08A RID: 123018
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnsignedCharArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E08B RID: 123019 RVA: 0x002A70EC File Offset: 0x002A52EC
		public static byte GetDataTypeValueMax()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E08C RID: 123020
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUnsignedCharArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E08D RID: 123021 RVA: 0x002A7108 File Offset: 0x002A5308
		public static byte GetDataTypeValueMin()
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E08E RID: 123022
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedCharArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E08F RID: 123023 RVA: 0x002A7124 File Offset: 0x002A5324
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E090 RID: 123024
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedCharArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E091 RID: 123025 RVA: 0x002A7144 File Offset: 0x002A5344
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E092 RID: 123026
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedCharArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E093 RID: 123027 RVA: 0x002A7160 File Offset: 0x002A5360
		public override int IsA(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E094 RID: 123028
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedCharArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E095 RID: 123029 RVA: 0x002A7180 File Offset: 0x002A5380
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedCharArray.vtkUnsignedCharArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E096 RID: 123030
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedCharArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E097 RID: 123031 RVA: 0x002A719C File Offset: 0x002A539C
		public new vtkUnsignedCharArray NewInstance()
		{
			vtkUnsignedCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E098 RID: 123032
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedCharArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E099 RID: 123033 RVA: 0x002A71F8 File Offset: 0x002A53F8
		public new static vtkUnsignedCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedCharArray.vtkUnsignedCharArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB1 RID: 8113
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedCharArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB2 RID: 8114
		public new static readonly string MRClassNameKey = "class vtkUnsignedCharArray";
	}
}
