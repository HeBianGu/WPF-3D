using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFieldDataSerializer
	///
	///
	///  A concrete instance of vtkObject which provides functionality for
	///  serializing and de-serializing field data, primarily used for the purpose
	///  of preparing the data for transfer over MPI or other communication
	///  mechanism.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkFieldData vtkPointData vtkCellData vtkMultiProcessStream
	/// </seealso>
	// Token: 0x020006F7 RID: 1783
	public class vtkFieldDataSerializer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012C97 RID: 76951 RVA: 0x001A6F9E File Offset: 0x001A519E
		static vtkFieldDataSerializer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldDataSerializer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldDataSerializer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012C98 RID: 76952 RVA: 0x001A6FC6 File Offset: 0x001A51C6
		public vtkFieldDataSerializer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012C99 RID: 76953
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataSerializer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C9A RID: 76954 RVA: 0x001A6FD4 File Offset: 0x001A51D4
		public new static vtkFieldDataSerializer New()
		{
			vtkFieldDataSerializer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataSerializer.vtkFieldDataSerializer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C9B RID: 76955 RVA: 0x001A7028 File Offset: 0x001A5228
		public vtkFieldDataSerializer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFieldDataSerializer.vtkFieldDataSerializer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012C9C RID: 76956 RVA: 0x001A706C File Offset: 0x001A526C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012C9D RID: 76957
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataSerializer_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C9E RID: 76958 RVA: 0x001A7078 File Offset: 0x001A5278
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFieldDataSerializer.vtkFieldDataSerializer_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012C9F RID: 76959
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataSerializer_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CA0 RID: 76960 RVA: 0x001A7098 File Offset: 0x001A5298
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFieldDataSerializer.vtkFieldDataSerializer_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012CA1 RID: 76961
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataSerializer_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CA2 RID: 76962 RVA: 0x001A70B4 File Offset: 0x001A52B4
		public override int IsA(string type)
		{
			return vtkFieldDataSerializer.vtkFieldDataSerializer_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012CA3 RID: 76963
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataSerializer_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CA4 RID: 76964 RVA: 0x001A70D4 File Offset: 0x001A52D4
		public new static int IsTypeOf(string type)
		{
			return vtkFieldDataSerializer.vtkFieldDataSerializer_IsTypeOf_04(type);
		}

		// Token: 0x06012CA5 RID: 76965
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataSerializer_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CA6 RID: 76966 RVA: 0x001A70F0 File Offset: 0x001A52F0
		public new vtkFieldDataSerializer NewInstance()
		{
			vtkFieldDataSerializer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataSerializer.vtkFieldDataSerializer_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012CA7 RID: 76967
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataSerializer_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CA8 RID: 76968 RVA: 0x001A714C File Offset: 0x001A534C
		public new static vtkFieldDataSerializer SafeDownCast(vtkObjectBase o)
		{
			vtkFieldDataSerializer vtkFieldDataSerializer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataSerializer.vtkFieldDataSerializer_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldDataSerializer = (vtkFieldDataSerializer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldDataSerializer.Register(null);
				}
			}
			return vtkFieldDataSerializer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B5 RID: 5557
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldDataSerializer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B6 RID: 5558
		public new static readonly string MRClassNameKey = "class vtkFieldDataSerializer";
	}
}
