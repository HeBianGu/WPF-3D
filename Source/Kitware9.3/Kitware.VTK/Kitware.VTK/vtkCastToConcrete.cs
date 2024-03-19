using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCastToConcrete
	/// </summary>
	/// <remarks>
	///    works around type-checking limitations
	///
	/// vtkCastToConcrete is a filter that works around type-checking limitations
	/// in the filter classes. Some filters generate abstract types on output,
	/// and cannot be connected to the input of filters requiring a concrete
	/// input type. For example, vtkElevationFilter generates vtkDataSet for output,
	/// and cannot be connected to vtkDecimate, because vtkDecimate requires
	/// vtkPolyData as input. This is true even though (in this example) the input
	/// to vtkElevationFilter is of type vtkPolyData, and you know the output of
	/// vtkElevationFilter is the same type as its input.
	///
	/// vtkCastToConcrete performs run-time checking to ensure that output type
	/// is of the right type. An error message will result if you try to cast
	/// an input type improperly. Otherwise, the filter performs the appropriate
	/// cast and returns the data.
	///
	/// @warning
	/// You must specify the input before you can get the output. Otherwise an
	/// error results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetAlgorithm vtkPointSetToPointSetFilter
	/// </seealso>
	// Token: 0x020009C9 RID: 2505
	public class vtkCastToConcrete : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A26E RID: 107118 RVA: 0x00243E5B File Offset: 0x0024205B
		static vtkCastToConcrete()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCastToConcrete.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCastToConcrete"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A26F RID: 107119 RVA: 0x00243E83 File Offset: 0x00242083
		public vtkCastToConcrete(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A270 RID: 107120
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCastToConcrete_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A271 RID: 107121 RVA: 0x00243E94 File Offset: 0x00242094
		public new static vtkCastToConcrete New()
		{
			vtkCastToConcrete result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A272 RID: 107122 RVA: 0x00243EE8 File Offset: 0x002420E8
		public vtkCastToConcrete() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCastToConcrete.vtkCastToConcrete_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A273 RID: 107123 RVA: 0x00243F2C File Offset: 0x0024212C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A274 RID: 107124
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCastToConcrete_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A275 RID: 107125 RVA: 0x00243F38 File Offset: 0x00242138
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A276 RID: 107126
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCastToConcrete_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A277 RID: 107127 RVA: 0x00243F58 File Offset: 0x00242158
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A278 RID: 107128
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCastToConcrete_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A279 RID: 107129 RVA: 0x00243F74 File Offset: 0x00242174
		public override int IsA(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A27A RID: 107130
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCastToConcrete_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A27B RID: 107131 RVA: 0x00243F94 File Offset: 0x00242194
		public new static int IsTypeOf(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_IsTypeOf_04(type);
		}

		// Token: 0x0601A27C RID: 107132
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCastToConcrete_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A27D RID: 107133 RVA: 0x00243FB0 File Offset: 0x002421B0
		public new vtkCastToConcrete NewInstance()
		{
			vtkCastToConcrete result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A27E RID: 107134
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCastToConcrete_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A27F RID: 107135 RVA: 0x0024400C File Offset: 0x0024220C
		public new static vtkCastToConcrete SafeDownCast(vtkObjectBase o)
		{
			vtkCastToConcrete vtkCastToConcrete = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCastToConcrete = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCastToConcrete.Register(null);
				}
			}
			return vtkCastToConcrete;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5F RID: 7263
		public new const string MRFullTypeName = "Kitware.VTK.vtkCastToConcrete";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C60 RID: 7264
		public new static readonly string MRClassNameKey = "class vtkCastToConcrete";
	}
}
