using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTrivialConsumer
	/// </summary>
	/// <remarks>
	///    Consumer to consume data off of a pipeline.
	///
	/// vtkTrivialConsumer caps off a pipeline so that no output data is left
	/// hanging around when a pipeline executes when data is set to be released (see
	/// vtkDataObject::SetGlobalReleaseDataFlag). This is intended to be used for
	/// tools such as Catalyst and not end users.
	/// </remarks>
	// Token: 0x020009E8 RID: 2536
	public class vtkTrivialConsumer : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A622 RID: 108066 RVA: 0x0024A193 File Offset: 0x00248393
		static vtkTrivialConsumer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTrivialConsumer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTrivialConsumer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A623 RID: 108067 RVA: 0x0024A1BB File Offset: 0x002483BB
		public vtkTrivialConsumer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A624 RID: 108068
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialConsumer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A625 RID: 108069 RVA: 0x0024A1CC File Offset: 0x002483CC
		public new static vtkTrivialConsumer New()
		{
			vtkTrivialConsumer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialConsumer.vtkTrivialConsumer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialConsumer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A626 RID: 108070 RVA: 0x0024A220 File Offset: 0x00248420
		public vtkTrivialConsumer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTrivialConsumer.vtkTrivialConsumer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A627 RID: 108071 RVA: 0x0024A264 File Offset: 0x00248464
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A628 RID: 108072
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTrivialConsumer_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A629 RID: 108073 RVA: 0x0024A270 File Offset: 0x00248470
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTrivialConsumer.vtkTrivialConsumer_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A62A RID: 108074
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTrivialConsumer_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A62B RID: 108075 RVA: 0x0024A290 File Offset: 0x00248490
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTrivialConsumer.vtkTrivialConsumer_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A62C RID: 108076
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTrivialConsumer_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A62D RID: 108077 RVA: 0x0024A2AC File Offset: 0x002484AC
		public override int IsA(string type)
		{
			return vtkTrivialConsumer.vtkTrivialConsumer_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A62E RID: 108078
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTrivialConsumer_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A62F RID: 108079 RVA: 0x0024A2CC File Offset: 0x002484CC
		public new static int IsTypeOf(string type)
		{
			return vtkTrivialConsumer.vtkTrivialConsumer_IsTypeOf_04(type);
		}

		// Token: 0x0601A630 RID: 108080
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialConsumer_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A631 RID: 108081 RVA: 0x0024A2E8 File Offset: 0x002484E8
		public new vtkTrivialConsumer NewInstance()
		{
			vtkTrivialConsumer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialConsumer.vtkTrivialConsumer_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialConsumer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A632 RID: 108082
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialConsumer_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A633 RID: 108083 RVA: 0x0024A344 File Offset: 0x00248544
		public new static vtkTrivialConsumer SafeDownCast(vtkObjectBase o)
		{
			vtkTrivialConsumer vtkTrivialConsumer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialConsumer.vtkTrivialConsumer_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTrivialConsumer = (vtkTrivialConsumer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTrivialConsumer.Register(null);
				}
			}
			return vtkTrivialConsumer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA0 RID: 7328
		public new const string MRFullTypeName = "Kitware.VTK.vtkTrivialConsumer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA1 RID: 7329
		public new static readonly string MRClassNameKey = "class vtkTrivialConsumer";
	}
}
