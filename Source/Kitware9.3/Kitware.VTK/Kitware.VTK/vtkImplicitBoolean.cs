using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitBoolean
	/// </summary>
	/// <remarks>
	///    implicit function consisting of boolean combinations of implicit functions
	///
	/// vtkImplicitBoolean is an implicit function consisting of boolean
	/// combinations of implicit functions. The class has a list of functions
	/// (FunctionList) that are combined according to a specified operator
	/// (VTK_UNION or VTK_INTERSECTION or VTK_DIFFERENCE). You can use nested
	/// combinations of vtkImplicitFunction's (and/or vtkImplicitBoolean) to create
	/// elaborate implicit functions.  vtkImplicitBoolean is a concrete
	/// implementation of vtkImplicitFunction.
	///
	/// The operators work as follows. The VTK_UNION operator takes the minimum
	/// value of all implicit functions. The VTK_INTERSECTION operator takes the
	/// maximum value of all implicit functions. The VTK_DIFFERENCE operator
	/// subtracts the 2nd through last implicit functions from the first. The
	/// VTK_UNION_OF_MAGNITUDES takes the minimum absolute value of the
	/// implicit functions.
	/// </remarks>
	// Token: 0x02000A65 RID: 2661
	public class vtkImplicitBoolean : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BDF1 RID: 114161 RVA: 0x00270A46 File Offset: 0x0026EC46
		static vtkImplicitBoolean()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitBoolean.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitBoolean"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BDF2 RID: 114162 RVA: 0x00270A6E File Offset: 0x0026EC6E
		public vtkImplicitBoolean(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BDF3 RID: 114163
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitBoolean_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Default boolean method is union.
		/// </summary>
		// Token: 0x0601BDF4 RID: 114164 RVA: 0x00270A7C File Offset: 0x0026EC7C
		public new static vtkImplicitBoolean New()
		{
			vtkImplicitBoolean result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Default boolean method is union.
		/// </summary>
		// Token: 0x0601BDF5 RID: 114165 RVA: 0x00270AD0 File Offset: 0x0026ECD0
		public vtkImplicitBoolean() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitBoolean.vtkImplicitBoolean_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BDF6 RID: 114166 RVA: 0x00270B14 File Offset: 0x0026ED14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BDF7 RID: 114167
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_AddFunction_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add another implicit function to the list of functions.
		/// </summary>
		// Token: 0x0601BDF8 RID: 114168 RVA: 0x00270B20 File Offset: 0x0026ED20
		public void AddFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_AddFunction_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BDF9 RID: 114169
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitBoolean_EvaluateFunction_02(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate boolean combinations of implicit function using current operator.
		/// </summary>
		// Token: 0x0601BDFA RID: 114170 RVA: 0x00270B50 File Offset: 0x0026ED50
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_EvaluateFunction_02(base.GetCppThis(), x);
		}

		// Token: 0x0601BDFB RID: 114171
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate gradient of boolean combination.
		/// </summary>
		// Token: 0x0601BDFC RID: 114172 RVA: 0x00270B70 File Offset: 0x0026ED70
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		// Token: 0x0601BDFD RID: 114173
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitBoolean_GetFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the collection of implicit functions.
		/// </summary>
		// Token: 0x0601BDFE RID: 114174 RVA: 0x00270B84 File Offset: 0x0026ED84
		public vtkImplicitFunctionCollection GetFunction()
		{
			vtkImplicitFunctionCollection vtkImplicitFunctionCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_GetFunction_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunctionCollection = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunctionCollection.Register(null);
				}
			}
			return vtkImplicitFunctionCollection;
		}

		// Token: 0x0601BDFF RID: 114175
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitBoolean_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Override modified time retrieval because of object dependencies.
		/// </summary>
		// Token: 0x0601BE00 RID: 114176 RVA: 0x00270BF4 File Offset: 0x0026EDF4
		public override ulong GetMTime()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0601BE01 RID: 114177
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitBoolean_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE02 RID: 114178 RVA: 0x00270C14 File Offset: 0x0026EE14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601BE03 RID: 114179
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitBoolean_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE04 RID: 114180 RVA: 0x00270C34 File Offset: 0x0026EE34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601BE05 RID: 114181
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitBoolean_GetOperationType_08(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE06 RID: 114182 RVA: 0x00270C50 File Offset: 0x0026EE50
		public virtual int GetOperationType()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationType_08(base.GetCppThis());
		}

		// Token: 0x0601BE07 RID: 114183
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitBoolean_GetOperationTypeAsString_09(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE08 RID: 114184 RVA: 0x00270C70 File Offset: 0x0026EE70
		public string GetOperationTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601BE09 RID: 114185
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitBoolean_GetOperationTypeMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE0A RID: 114186 RVA: 0x00270CAC File Offset: 0x0026EEAC
		public virtual int GetOperationTypeMaxValue()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0601BE0B RID: 114187
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitBoolean_GetOperationTypeMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE0C RID: 114188 RVA: 0x00270CCC File Offset: 0x0026EECC
		public virtual int GetOperationTypeMinValue()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeMinValue_11(base.GetCppThis());
		}

		// Token: 0x0601BE0D RID: 114189
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitBoolean_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE0E RID: 114190 RVA: 0x00270CEC File Offset: 0x0026EEEC
		public override int IsA(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601BE0F RID: 114191
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitBoolean_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE10 RID: 114192 RVA: 0x00270D0C File Offset: 0x0026EF0C
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_IsTypeOf_13(type);
		}

		// Token: 0x0601BE11 RID: 114193
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitBoolean_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE12 RID: 114194 RVA: 0x00270D28 File Offset: 0x0026EF28
		public new vtkImplicitBoolean NewInstance()
		{
			vtkImplicitBoolean result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BE13 RID: 114195
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_RemoveFunction_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a function from the list of implicit functions to boolean.
		/// </summary>
		// Token: 0x0601BE14 RID: 114196 RVA: 0x00270D84 File Offset: 0x0026EF84
		public void RemoveFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_RemoveFunction_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BE15 RID: 114197
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitBoolean_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE16 RID: 114198 RVA: 0x00270DB4 File Offset: 0x0026EFB4
		public new static vtkImplicitBoolean SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitBoolean vtkImplicitBoolean = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitBoolean = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitBoolean.Register(null);
				}
			}
			return vtkImplicitBoolean;
		}

		// Token: 0x0601BE17 RID: 114199
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_SetOperationType_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE18 RID: 114200 RVA: 0x00270E33 File Offset: 0x0026F033
		public virtual void SetOperationType(int _arg)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationType_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE19 RID: 114201
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToDifference_19(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE1A RID: 114202 RVA: 0x00270E43 File Offset: 0x0026F043
		public void SetOperationTypeToDifference()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToDifference_19(base.GetCppThis());
		}

		// Token: 0x0601BE1B RID: 114203
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToIntersection_20(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE1C RID: 114204 RVA: 0x00270E52 File Offset: 0x0026F052
		public void SetOperationTypeToIntersection()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToIntersection_20(base.GetCppThis());
		}

		// Token: 0x0601BE1D RID: 114205
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToUnion_21(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE1E RID: 114206 RVA: 0x00270E61 File Offset: 0x0026F061
		public void SetOperationTypeToUnion()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToUnion_21(base.GetCppThis());
		}

		// Token: 0x0601BE1F RID: 114207
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_22(HandleRef pThis);

		/// <summary>
		/// Specify the type of boolean operation.
		/// </summary>
		// Token: 0x0601BE20 RID: 114208 RVA: 0x00270E70 File Offset: 0x0026F070
		public void SetOperationTypeToUnionOfMagnitudes()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBE RID: 7614
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitBoolean";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DBF RID: 7615
		public new static readonly string MRClassNameKey = "class vtkImplicitBoolean";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000A66 RID: 2662
		public enum OperationType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001DC1 RID: 7617
			VTK_DIFFERENCE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001DC2 RID: 7618
			VTK_INTERSECTION = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001DC3 RID: 7619
			VTK_UNION = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001DC4 RID: 7620
			VTK_UNION_OF_MAGNITUDES = 3
		}
	}
}
